using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BitmexBot
{
    public class OrderBookItem
    {
        public string Symbol { get; set; }
        public int Level { get; set; }
        public int BidSize { get; set; }
        public decimal BidPrice { get; set; }
        public int AskSize { get; set; }
        public decimal AskPrice { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class BitMEXApi
    {
        private string domain = "https://testnet.bitmex.com";
        private string apiKey;
        private string apiSecret;
        private int rateLimit;

        public BitMEXApi(string bitmexKey = "", string bitmexSecret = "", string bitmexDomain = "", int rateLimit = 5000)
        {
            this.apiKey = bitmexKey;
            this.apiSecret = bitmexSecret;
            this.rateLimit = rateLimit;
            this.domain = bitmexDomain;
        }

        #region API Connector - Don't touch
        private string BuildQueryData(Dictionary<string, string> param)
        {
            if (param == null)
                return "";

            StringBuilder b = new StringBuilder();
            foreach (var item in param)
            {
                if (item.Key != "filter" && item.Key != "orders") // SUPER IMPORTANT, WE MUST ENCODE OUR OWN FILTER STRINGS WHEN PASSING HTEM AS QUERY
                {
                    b.Append(string.Format("&{0}={1}", item.Key, WebUtility.UrlEncode(item.Value)));
                }
                else
                {
                    b.Append(string.Format("&{0}={1}", item.Key, item.Value));
                }
            }

            try { return b.ToString().Substring(1); }
            catch (Exception) { return ""; }
        }

        private string BuildJSON(Dictionary<string, string> param)
        {
            if (param == null)
                return "";

            var entries = new List<string>();
            foreach (var item in param)
                entries.Add(string.Format("\"{0}\":\"{1}\"", item.Key, item.Value));

            return "{" + string.Join(",", entries) + "}";
        }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        private long GetNonce()
        {
            DateTime yearBegin = new DateTime(2018, 8, 7);
            return DateTime.UtcNow.Ticks - yearBegin.Ticks;
        }

        private byte[] hmacsha256(byte[] keyByte, byte[] messageBytes)
        {
            using (var hash = new HMACSHA256(keyByte))
            {
                return hash.ComputeHash(messageBytes);
            }
        }

        public string GetExpiresArg()
        {
            long timestamp = (long)((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);

            string expires = (timestamp + 60).ToString();

            return (expires);
        }

        private string Query(string method, string function, Dictionary<string, string> param = null, bool auth = false, bool json = false)
        {
            string paramData = json ? BuildJSON(param) : BuildQueryData(param);
            string url = "/api/v1" + function + ((method == "GET" && paramData != "") ? "?" + paramData : "");
            string postData = (method != "GET") ? paramData : "";

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(domain + url);
            webRequest.Method = method;

            if (auth)
            {
                string nonce = GetNonce().ToString();
                string message2 = method + url + nonce + postData;
                string expires = GetExpiresArg();
                string message = method + url + expires + postData;
                byte[] signatureBytes = hmacsha256(Encoding.UTF8.GetBytes(apiSecret), Encoding.UTF8.GetBytes(message));
                string signatureString = ByteArrayToString(signatureBytes);

                //webRequest.Headers.Add("api-nonce", nonce);
                webRequest.Headers.Add("api-expires", expires);
                webRequest.Headers.Add("api-key", apiKey);
                webRequest.Headers.Add("api-signature", signatureString);
            }

            try
            {
                if (postData != "")
                {
                    webRequest.ContentType = json ? "application/json" : "application/x-www-form-urlencoded";
                    var data = Encoding.UTF8.GetBytes(postData);
                    using (var stream = webRequest.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }
                }

                using (WebResponse webResponse = webRequest.GetResponse())
                using (Stream str = webResponse.GetResponseStream())
                using (StreamReader sr = new StreamReader(str))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (WebException wex)
            {
                using (HttpWebResponse response = (HttpWebResponse)wex.Response)
                {
                    if (response == null)
                        throw;

                    using (Stream str = response.GetResponseStream())
                    {
                        using (StreamReader sr = new StreamReader(str))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }

        private async Task<string> QueryAsync(string method, string function, Dictionary<string, string> param = null, bool auth = false, bool json = false)
        {
            string paramData = json ? BuildJSON(param) : BuildQueryData(param);
            string url = "/api/v1" + function + ((method == "GET" && paramData != "") ? "?" + paramData : "");
            string postData = (method != "GET") ? paramData : "";

            String responseText = await Task.Run(() =>
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(domain + url);
                webRequest.Method = method;

                if (auth)
                {
                    string nonce = GetNonce().ToString();
                    string message2 = method + url + nonce + postData;
                    string expires = GetExpiresArg();
                    string message = method + url + expires + postData;
                    byte[] signatureBytes = hmacsha256(Encoding.UTF8.GetBytes(apiSecret), Encoding.UTF8.GetBytes(message));
                    string signatureString = ByteArrayToString(signatureBytes);

                    //webRequest.Headers.Add("api-nonce", nonce);
                    webRequest.Headers.Add("api-expires", expires);
                    webRequest.Headers.Add("api-key", apiKey);
                    webRequest.Headers.Add("api-signature", signatureString);
                }

                try
                {
                    if (postData != "")
                    {
                        webRequest.ContentType = json ? "application/json" : "application/x-www-form-urlencoded";
                        var data = Encoding.UTF8.GetBytes(postData);
                        using (var stream = webRequest.GetRequestStream())
                        {
                            stream.Write(data, 0, data.Length);
                        }
                    }

                    using (WebResponse webResponse = webRequest.GetResponse())
                    using (Stream str = webResponse.GetResponseStream())
                    using (StreamReader sr = new StreamReader(str))
                    {
                        return sr.ReadToEnd();
                    }
                }
                catch (WebException wex)
                {
                    using (HttpWebResponse response = (HttpWebResponse)wex.Response)
                    {
                        if (response == null)
                            throw;

                        using (Stream str = response.GetResponseStream())
                        {
                            using (StreamReader sr = new StreamReader(str))
                            {
                                return sr.ReadToEnd();
                            }
                        }
                    }
                }
            });

            return responseText;
        }
        #endregion

        #region Our Calls
        public List<OrderBook> GetOrderBook(string symbol, int depth)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = symbol;
            param["depth"] = depth.ToString();
            string res = Query("GET", "/orderBook/L2", param);
            return JsonConvert.DeserializeObject<List<OrderBook>>(res);
        }

        public async Task<List<OrderBook>> GetOrderBookAsync(string symbol, int depth)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = symbol;
            param["depth"] = depth.ToString();
            string res = await QueryAsync("GET", "/orderBook/L2", param);

            return JsonConvert.DeserializeObject<List<OrderBook>>(res);
        }

        public string PostOrderPostOnly(string Symbol, string Side, double Price, int Quantity)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = Symbol;
            param["side"] = Side;
            param["orderQty"] = Quantity.ToString();
            param["ordType"] = "Limit";
            param["execInst"] = "ParticipateDoNotInitiate";
            param["displayQty"] = 0.ToString(); // Shows the order as hidden, keeps us from moving price away from our own orders
            param["price"] = Price.ToString();
            return Query("POST", "/order", param, true);
        }

        public string MarketOrder(string Symbol, string Side, int Quantity)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = Symbol;
            param["side"] = Side;
            param["orderQty"] = Quantity.ToString();
            param["ordType"] = "Market";
            return Query("POST", "/order", param, true);
        }

        public string BulkOrder(string Orders)
        {
            var param = new Dictionary<string, string>();
            param["orders"] = Orders;
            return Query("POST", "/order/bulk", param, true);
        }

        public string AmendBulkOrder(string Orders)
        {
            var param = new Dictionary<string, string>();
            param["orders"] = Orders;
            return Query("PUT", "/order/bulk", param, true);
        }

        public string CancelAllOpenOrders(string symbol, string Note = "")
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = symbol;
            param["text"] = Note;
            return Query("DELETE", "/order/all", param, true, true);
        }

        public List<Instrument> GetActiveInstruments()
        {
            string res = Query("GET", "/instrument/active");
            return JsonConvert.DeserializeObject<List<Instrument>>(res);
        }

        public List<Instrument> GetInstrument(string symbol)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = symbol;
            string res = Query("GET", "/instrument", param);
            return JsonConvert.DeserializeObject<List<Instrument>>(res);
        }

        public List<Candle> GetCandleHistory(string symbol, int count, string size)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = symbol;
            param["count"] = count.ToString();
            param["reverse"] = true.ToString();
            param["partial"] = false.ToString();
            param["binSize"] = size;
            string res = Query("GET", "/trade/bucketed", param);
            return JsonConvert.DeserializeObject<List<Candle>>(res).OrderByDescending(a => a.TimeStamp).ToList();
        }

        public List<Candle> GetCandleHistory(string symbol, int count, string size, DateTime startTime, DateTime endTime)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = symbol;
            param["count"] = count.ToString();
            param["reverse"] = true.ToString();
            param["partial"] = false.ToString();
            param["binSize"] = size;
            param["start_time"] = startTime.ToString();
            param["end_time"] = endTime.ToString();
            string res = Query("GET", "/trade/bucketed", param);
            return JsonConvert.DeserializeObject<List<Candle>>(res).OrderByDescending(a => a.TimeStamp).ToList();
        }

        public List<Position> GetOpenPositions(string symbol)
        {
            var param = new Dictionary<string, string>();
            string res = Query("GET", "/position", param, true);
            return JsonConvert.DeserializeObject<List<Position>>(res).Where(a => a.Symbol == symbol && a.IsOpen == true).OrderByDescending(a => a.TimeStamp).ToList();
        }

        public List<Order> GetOpenOrders(string symbol)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = symbol;
            param["reverse"] = true.ToString();
            string res = Query("GET", "/order", param, true);
            return JsonConvert.DeserializeObject<List<Order>>(res).Where(a => a.OrdStatus == "New" || a.OrdStatus == "PartiallyFilled").OrderByDescending(a => a.TimeStamp).ToList();
        }

        public string EditOrderPrice(string OrderId, double Price)
        {
            var param = new Dictionary<string, string>();
            param["orderID"] = OrderId;
            param["price"] = Price.ToString();
            return Query("PUT", "/order", param, true, true);
        }

        public PositionLeverage Leverage(string symbol, double leverage)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = symbol;
            param["leverage"] = leverage.ToString();

            string res = Query("POST", "/position/leverage", param, true);

            return JsonConvert.DeserializeObject<PositionLeverage>(res);
        }

        // Getting Account Balance
        public double GetAccountBalance()
        {
            var param = new Dictionary<string, string>();
            param["currency"] = "XBt";
            string res = Query("GET", "/user/margin", param, true);
            if (res.Contains("error"))
            {
                return -1;
            }
            else
            {
                return Convert.ToDouble(JsonConvert.DeserializeObject<Margin>(res).UsefulBalance); // useful balance is the balance with full decimal places.
                // default wallet balance doesn't show the decimal places like it should.
            }
        }

        // Market Stops
        public string MarketStop(string Symbol, string Side, double StopPrice, int Quantity, bool ReduceOnly, string timeframe, string text = "BMBStopMarket")
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = Symbol;
            param["side"] = Side;
            param["orderQty"] = Quantity.ToString();
            param["stopPx"] = StopPrice.ToString();
            param["ordType"] = "Stop";
            param["text"] = text + timeframe;
            if (ReduceOnly)
            {
                param["execInst"] = "ReduceOnly,LastPrice"; // Implies reduce position
            }
            else
            {
                param["execInst"] = "LastPrice";
            }
            return Query("POST", "/order", param, true);
        }

        #endregion

        #region RateLimiter

        private long lastTicks = 0;
        private object thisLock = new object();

        private void RateLimit()
        {
            lock (thisLock)
            {
                long elapsedTicks = DateTime.Now.Ticks - lastTicks;
                var timespan = new TimeSpan(elapsedTicks);
                if (timespan.TotalMilliseconds < rateLimit)
                    Thread.Sleep(rateLimit - (int)timespan.TotalMilliseconds);
                lastTicks = DateTime.Now.Ticks;
            }
        }

        #endregion RateLimiter
    }

    // Working Classes
    public class Margin // For account balance
    {
        public double? WalletBalance { get; set; }
        public double? AvailableMargin { get; set; }
        public double? UsefulBalance
        {
            get { return (WalletBalance / 100000000) ?? 0; }
        }
    }

    public class OrderBook
    {
        public string Side { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }
    }

    public class Instrument
    {
        public string Symbol { get; set; }
        public double TickSize { get; set; }
        public double Volume24H { get; set; }
    }
}
