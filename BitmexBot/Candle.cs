using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmexBot
{
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
}
