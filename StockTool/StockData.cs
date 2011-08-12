using System;
using System.Collections;

namespace StockTool
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

        public StockData() { }

        public StockData(string code) { this.code = code; }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
        public StockData Clone()
        {
            return (StockData)this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            if (obj is StockData)
                return code.CompareTo(((StockData)obj).code);
            else if (obj is string)
            {
                int i = code.CompareTo((string)obj);
                return i;
            }

            throw new ArgumentException("Object type mis-matched");
        }
    }

    public class ExtentedStockData : StockData
    {
        public float ask = float.NaN;
        public float bit = float.NaN;
    }
}
