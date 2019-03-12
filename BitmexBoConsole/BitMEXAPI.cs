//using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using System.Collections;
using System.Linq;

namespace BitMEX
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
        private const string domain = "https://testnet.bitmex.com";
        private string apiKey;
        private string apiSecret;
        private int rateLimit;

        public BitMEXApi(string bitmexKey = "", string bitmexSecret = "", int rateLimit = 5000)
        {
            this.apiKey = bitmexKey;
            this.apiSecret = bitmexSecret;
            this.rateLimit = rateLimit;
        }

        private string BuildQueryData(Dictionary<string, string> param)
        {
            if (param == null)
                return "";

            StringBuilder b = new StringBuilder();
            foreach (var item in param)
                b.Append(string.Format("&{0}={1}", item.Key, WebUtility.UrlEncode(item.Value)));

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

        private long GetExpires()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeSeconds() + 3600; // set expires one hour in the future
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
                string expires = GetExpires().ToString();
                string message = method + url + expires + postData;
                byte[] signatureBytes = hmacsha256(Encoding.UTF8.GetBytes(apiSecret), Encoding.UTF8.GetBytes(message));
                string signatureString = ByteArrayToString(signatureBytes);

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

        //public List<OrderBookItem> GetOrderBook(string symbol, int depth)
        //{
        //    var param = new Dictionary<string, string>();
        //    param["symbol"] = symbol;
        //    param["depth"] = depth.ToString();
        //    string res = Query("GET", "/orderBook", param);
        //    return JsonSerializer.DeserializeFromString<List<OrderBookItem>>(res);
        //}

        public string GetOrders()
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = "XBTUSD";
            //param["filter"] = "{\"open\":true}";
            //param["columns"] = "";
            //param["count"] = 100.ToString();
            //param["start"] = 0.ToString();
            //param["reverse"] = false.ToString();
            //param["startTime"] = "";
            //param["endTime"] = "";
            return Query("GET", "/order", param, true);
        }

        public string PostOrders()
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = "XBTUSD";
            param["side"] = "Buy";
            param["orderQty"] = "1";
            param["ordType"] = "Market";
            return Query("POST", "/order", param, true);
        }

        public string DeleteOrders()
        {
            var param = new Dictionary<string, string>();
            param["orderID"] = "de709f12-2f24-9a36-b047-ab0ff090f0bb";
            param["text"] = "cancel order by ID";
            return Query("DELETE", "/order", param, true, true);
        }

        private byte[] hmacsha256(byte[] keyByte, byte[] messageBytes)
        {
            using (var hash = new HMACSHA256(keyByte))
            {
                return hash.ComputeHash(messageBytes);
            }
        }

        public PositionLeverage Leverage(string symbol, double leverage)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = symbol;
            param["leverage"] = leverage.ToString();

            string res = Query("POST", "/position/leverage", param, true);

            return JsonConvert.DeserializeObject<PositionLeverage>(res); 
        }

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
}