using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace StockTool
{
    class Layout
    {
        static public Color getRocColor(float roc)
        {
            int colorVal;
            if (roc > 0)
            {
                colorVal = (int)Math.Max(0, 230 - Math.Log(1 + roc, 11) * 230);
                return Color.FromArgb(colorVal, 255, colorVal);
            }
            else if (roc < 0)
            {
                colorVal = (int)Math.Max(0, 230 - Math.Log(1 - roc, 11) * 230);
                return Color.FromArgb(255, colorVal, colorVal);
            }
            else
                return Color.White;
        }
    }
}
