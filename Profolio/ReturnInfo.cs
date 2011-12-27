using System;
using System.Collections.Generic;
using System.Text;

namespace Profolio
{
    public class ReturnInfo
    {
        public string code;
        public double earning = 0;
        public double breakEven = 0;
        public double ROI = 0;

        public ReturnInfo()
        {
        }
        public ReturnInfo(string code)
        {
            this.code = code;
        }
    }
}
