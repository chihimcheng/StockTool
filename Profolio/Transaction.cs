using System;
using System.Collections.Generic;
using System.Text;

namespace Profolio
{
    public class Transaction
    {
        public string code;
        public DateTime date;
        public double amount = 0;
        public double payment = 0;
        public string description;
    }

    public class FutureTransaction : Transaction
    {
        public string contractCode;
    }
}
