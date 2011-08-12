using System;
using System.Collections;
using System.Text;

namespace stockMgr
{
    public class StockCollection
    {
        private ArrayList _collection;

        public StockCollection()
        {
            _collection = new ArrayList();
        }

        public StockCollection(int capacity)
        {
            _collection = new ArrayList(capacity);
        }

        public StockData this[int i]
        {
            get { return (StockData)_collection[i]; }
            set { _collection[i] = value; }
        }

        public StockData this[string code]
        {
            get
            {
                int target = _collection.BinarySearch(code);
                if (target >= 0)
                    return (StockData)_collection[target];
                else
                    return null;
            }
            set
            {
                int target = _collection.BinarySearch(code);
                if (target >= 0)
                    _collection[target] = value;
            }
        }

        public int Add(StockData stock)
        {
            int target = _collection.BinarySearch(stock);
            if (target >= 0)
                return -1;
            else
            {
                target = ~target;
                _collection.Insert(target, stock);
                return target;
            }
        }

        public int Find(StockData stock)
        {
            return _collection.BinarySearch(stock);
        }
        public int Find(string code)
        {
            return _collection.BinarySearch(code);
        }
    }
}
