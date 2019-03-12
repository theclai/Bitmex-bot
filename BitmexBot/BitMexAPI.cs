using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

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

    public class Candle
    {
        public DateTime TimeStamp { get; set; }
        public double? Open { get; set; }
        public double? Close { get; set; }
        public double? High { get; set; }
        public double? Low { get; set; }
        public double? Volume { get; set; }
        public int Trades { get; set; }
        public int PCC { get; set; }
        public double? MA1 { get; set; }
        public double? MA2 { get; set; }

        public double? ALMA { get; set; } // NEW - For ALMA

        public double? HMA { get; set; } // For HMA

        public double? WMA1 { get; set; }
        public double? WMA2 { get; set; }

        public double? BBUpper { get; set; }
        public double? BBMiddle { get; set; }
        public double? BBLower { get; set; }
        public double? BBPercentB // NEW - For BB Update
        {
            get { return ((Close - BBLower) / (BBUpper - BBLower)) ?? 0; } // 0 if null
        }

        public double? TypicalPriceVolume
        {
            get { return (TypicalPrice * Volume) ?? 0; } // 0 if null
        }
        public double? VWAP { get; set; }

        public double? PVT { get; set; } //for PVT

        public double? STOCHK { get; set; }
        public double? STOCHD { get; set; }

        public double? TypicalPrice
        {
            get { return ((High + Low + Close) / 3) ?? 0; } // 0 if null
        }//  For MFI
        public double? RawMoneyFlow
        {
            get { return (TypicalPrice * Volume) ?? 0; } // 0 if null
        }//  For MFI
        public double? MoneyFlowRatio { get; set; } //  For MFI
        public double? MoneyFlowChange { get; set; } //  For MFI // This gets set to the TypicalPrice of this candle, to the TypicalPrice of the previous candle
        public double? MFI { get; set; } //  For MFI


        public double? EMA1 { get; set; }
        public double? EMA2 { get; set; }
        public double? EMA3 { get; set; }
        public double? MACDLine { get; set; }
        public double? MACDSignalLine { get; set; }
        public double? MACDHistorgram { get; set; }
        public double? TR { get; set; }
        public double? ATR1 { get; set; }
        public double? ATR2 { get; set; }
        public double? GainOrLoss // For RSI
        {
            get { return (Close - Open) ?? 0; } // 0 if null
        }
        public double? RS { get; set; } // For RSI
        public double? RSI { get; set; } // For RSI
        public double? AVGGain { get; set; } // For RSI
        public double? AVGLoss { get; set; } // For RSI




        public void SetMoneyFlowChange(double? PreviousTypicalPrice) // NEW - For MFI
        {
            MoneyFlowChange = TypicalPrice - PreviousTypicalPrice;
        }

        public void SetTR(double? PreviousClose)
        {
            List<double?> TRs = new List<double?>();

            TRs.Add(High - Low);
            TRs.Add(Convert.ToDouble(Math.Abs(Convert.ToDecimal(High - PreviousClose))));
            TRs.Add(Convert.ToDouble(Math.Abs(Convert.ToDecimal(Low - PreviousClose))));

            TR = TRs.Max();
        }


    }

    public class Position
    {
        public DateTime TimeStamp { get; set; }
        public double? Leverage { get; set; }
        public int? CurrentQty { get; set; }
        public double? CurrentCost { get; set; }
        public bool IsOpen { get; set; }
        public double? MarkPrice { get; set; }
        public double? MarkValue { get; set; }
        public double? UnrealisedPnl { get; set; }
        public double? UnrealisedPnlPcnt { get; set; }
        public double? UnrealisedRoePcnt { get; set; }
        public double? AvgEntryPrice { get; set; }
        public double? BreakEvenPrice { get; set; }
        public double? LiquidationPrice { get; set; }
        public string Symbol { get; set; }
    }

    public class Order
    {
        public DateTime TimeStamp { get; set; }
        public string Symbol { get; set; }
        public string OrdStatus { get; set; }
        public string OrdType { get; set; }
        public string OrderId { get; set; }
        public string Side { get; set; }
        public double? Price { get; set; }
        public int? OrderQty { get; set; }
        public int? DisplayQty { get; set; }
    }

    public class PositionLeverage
    {
        [JsonProperty("account")]
        public long Account { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("underlying")]
        public string Underlying { get; set; }

        [JsonProperty("quoteCurrency")]
        public string QuoteCurrency { get; set; }

        [JsonProperty("commission")]
        public decimal Commission { get; set; }

        [JsonProperty("initMarginReq")]
        public decimal InitMarginReq { get; set; }

        [JsonProperty("maintMarginReq")]
        public decimal MaintMarginReq { get; set; }

        [JsonProperty("riskLimit")]
        public decimal RiskLimit { get; set; }

        [JsonProperty("leverage")]
        public decimal Leverage { get; set; }

        [JsonProperty("crossMargin")]
        public bool CrossMargin { get; set; }

        [JsonProperty("deleveragePercentile")]
        public decimal? DeleveragePercentile { get; set; }

        [JsonProperty("rebalancedPnl")]
        public decimal RebalancedPnl { get; set; }

        [JsonProperty("prevRealisedPnl")]
        public decimal PrevRealisedPnl { get; set; }

        [JsonProperty("prevUnrealisedPnl")]
        public decimal PrevUnrealisedPnl { get; set; }

        [JsonProperty("prevClosePrice")]
        public decimal PrevClosePrice { get; set; }

        [JsonProperty("openingTimestamp")]
        public System.DateTimeOffset OpeningTimestamp { get; set; }

        [JsonProperty("openingQty")]
        public decimal OpeningQty { get; set; }

        [JsonProperty("openingCost")]
        public decimal OpeningCost { get; set; }

        [JsonProperty("openingComm")]
        public decimal OpeningComm { get; set; }

        [JsonProperty("openOrderBuyQty")]
        public decimal OpenOrderBuyQty { get; set; }

        [JsonProperty("openOrderBuyCost")]
        public decimal OpenOrderBuyCost { get; set; }

        [JsonProperty("openOrderBuyPremium")]
        public decimal OpenOrderBuyPremium { get; set; }

        [JsonProperty("openOrderSellQty")]
        public decimal OpenOrderSellQty { get; set; }

        [JsonProperty("openOrderSellCost")]
        public decimal OpenOrderSellCost { get; set; }

        [JsonProperty("openOrderSellPremium")]
        public decimal OpenOrderSellPremium { get; set; }

        [JsonProperty("execBuyQty")]
        public decimal ExecBuyQty { get; set; }

        [JsonProperty("execBuyCost")]
        public decimal ExecBuyCost { get; set; }

        [JsonProperty("execSellQty")]
        public decimal ExecSellQty { get; set; }

        [JsonProperty("execSellCost")]
        public decimal ExecSellCost { get; set; }

        [JsonProperty("execQty")]
        public decimal ExecQty { get; set; }

        [JsonProperty("execCost")]
        public decimal ExecCost { get; set; }

        [JsonProperty("execComm")]
        public decimal ExecComm { get; set; }

        [JsonProperty("currentTimestamp")]
        public System.DateTimeOffset CurrentTimestamp { get; set; }

        [JsonProperty("currentQty")]
        public decimal CurrentQty { get; set; }

        [JsonProperty("currentCost")]
        public decimal CurrentCost { get; set; }

        [JsonProperty("currentComm")]
        public decimal? CurrentComm { get; set; }

        [JsonProperty("realisedCost")]
        public decimal RealisedCost { get; set; }

        [JsonProperty("unrealisedCost")]
        public decimal UnrealisedCost { get; set; }

        [JsonProperty("grossOpenCost")]
        public decimal GrossOpenCost { get; set; }

        [JsonProperty("grossOpenPremium")]
        public decimal GrossOpenPremium { get; set; }

        [JsonProperty("grossExecCost")]
        public decimal GrossExecCost { get; set; }

        [JsonProperty("isOpen")]
        public bool IsOpen { get; set; }

        [JsonProperty("markPrice")]
        public decimal? MarkPrice { get; set; }

        [JsonProperty("markValue")]
        public decimal MarkValue { get; set; }

        [JsonProperty("riskValue")]
        public decimal RiskValue { get; set; }

        [JsonProperty("homeNotional")]
        public decimal HomeNotional { get; set; }

        [JsonProperty("foreignNotional")]
        public decimal ForeignNotional { get; set; }

        [JsonProperty("posState")]
        public string PosState { get; set; }

        [JsonProperty("posCost")]
        public decimal PosCost { get; set; }

        [JsonProperty("posCost2")]
        public decimal PosCost2 { get; set; }

        [JsonProperty("posCross")]
        public decimal PosCross { get; set; }

        [JsonProperty("posInit")]
        public decimal PosInit { get; set; }

        [JsonProperty("posComm")]
        public decimal PosComm { get; set; }

        [JsonProperty("posLoss")]
        public decimal PosLoss { get; set; }

        [JsonProperty("posMargin")]
        public decimal PosMargin { get; set; }

        [JsonProperty("posMaint")]
        public decimal PosMaint { get; set; }

        [JsonProperty("posAllowance")]
        public decimal PosAllowance { get; set; }

        [JsonProperty("taxableMargin")]
        public decimal TaxableMargin { get; set; }

        [JsonProperty("initMargin")]
        public decimal InitMargin { get; set; }

        [JsonProperty("maintMargin")]
        public decimal MaintMargin { get; set; }

        [JsonProperty("sessionMargin")]
        public decimal SessionMargin { get; set; }

        [JsonProperty("targetExcessMargin")]
        public decimal TargetExcessMargin { get; set; }

        [JsonProperty("varMargin")]
        public decimal VarMargin { get; set; }

        [JsonProperty("realisedGrossPnl")]
        public decimal RealisedGrossPnl { get; set; }

        [JsonProperty("realisedTax")]
        public decimal RealisedTax { get; set; }

        [JsonProperty("realisedPnl")]
        public decimal RealisedPnl { get; set; }

        [JsonProperty("unrealisedGrossPnl")]
        public decimal UnrealisedGrossPnl { get; set; }

        [JsonProperty("longBankrupt")]
        public decimal LongBankrupt { get; set; }

        [JsonProperty("shortBankrupt")]
        public decimal ShortBankrupt { get; set; }

        [JsonProperty("taxBase")]
        public decimal TaxBase { get; set; }

        [JsonProperty("indicativeTaxRate")]
        public decimal? IndicativeTaxRate { get; set; }

        [JsonProperty("indicativeTax")]
        public decimal IndicativeTax { get; set; }

        [JsonProperty("unrealisedTax")]
        public decimal UnrealisedTax { get; set; }

        [JsonProperty("unrealisedPnl")]
        public decimal UnrealisedPnl { get; set; }

        [JsonProperty("unrealisedPnlPcnt")]
        public decimal UnrealisedPnlPcnt { get; set; }

        [JsonProperty("unrealisedRoePcnt")]
        public decimal UnrealisedRoePcnt { get; set; }

        [JsonProperty("avgCostPrice")]
        public decimal? AvgCostPrice { get; set; }

        [JsonProperty("avgEntryPrice")]
        public decimal? AvgEntryPrice { get; set; }

        [JsonProperty("breakEvenPrice")]
        public decimal? BreakEvenPrice { get; set; }

        [JsonProperty("marginCallPrice")]
        public decimal? MarginCallPrice { get; set; }

        [JsonProperty("liquidationPrice")]
        public decimal? LiquidationPrice { get; set; }

        [JsonProperty("bankruptPrice")]
        public decimal? BankruptPrice { get; set; }

        [JsonProperty("timestamp")]
        public System.DateTimeOffset Timestamp { get; set; }

        [JsonProperty("lastPrice")]
        public decimal? LastPrice { get; set; }

        [JsonProperty("lastValue")]
        public decimal LastValue { get; set; }
    }
}
