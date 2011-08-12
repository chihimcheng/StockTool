using System;
using System.Collections;
using System.Drawing;

namespace stockMgr
{
    public class StockData : IComparable, ICloneable
    {
        public string code = null;
        public string name = null;
        public float open = float.NaN;
        public float close = float.NaN;
        public float high = float.NaN;
        public float low = float.NaN;
        public float volume = 0;
        public float change = 0;
        public float ROC = 0;

        static public string CodeFromString(string str)
        {
            string ret;
            int numCode;
            if (int.TryParse(str, out numCode))     //If only integer is entered, assume it is HK stock
                ret = str + ".HK";
            else
                ret = str.ToUpper();
            if (ret.EndsWith(".HK"))
                ret = ret.PadLeft(8, '0');
            return ret;
        }
        
        public StockData() { }

        public StockData(string code) { this.code = code; }

        public void CopyTo(StockData stock)
        {
            stock.code = this.code;
            stock.name = this.name;
            stock.open = this.open;
            stock.close = this.close;
            stock.high = this.high;
            stock.low = this.low;
            stock.volume = this.volume;
            stock.change = this.change;
            stock.ROC = this.ROC;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
        public StockData Clone()
        {
            return (StockData)this.MemberwiseClone();
        }

        #region IComparable 成員

        public int CompareTo(object obj)
        {
            if (obj is StockData)
                return code.CompareTo(((StockData)obj).code);
            else if (obj is string)
                return code.CompareTo(obj);
            else
                throw new ArgumentException();
        }

        #endregion
    }

    public class ExtentedStockData : StockData
    {
        public ExtentedStockData(string code) : base(code) { }

        public float ask = float.NaN;
        public float bit = float.NaN;
        public Image img = null;
    }
}
