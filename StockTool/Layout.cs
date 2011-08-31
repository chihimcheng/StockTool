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
            double colorLightness;  //0 to 1
            if (roc > 0)
            {
                colorLightness = Math.Max(1 - Math.Log(1 + roc, 11), 0);
                int lightnessOther = (int)(224 * colorLightness);
                return Color.FromArgb(lightnessOther, (int)(38 * colorLightness + 217), lightnessOther);
            }
            else if (roc < 0)
            {
                colorLightness = Math.Max(1 - Math.Log(1 - roc, 11), 0);
                int lightnessOther = (int)(164 * colorLightness + 73);
                return Color.FromArgb(255, lightnessOther, lightnessOther);
            }
            else
                return Color.White;
        }
    }
}
