using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfapp_metricconverter_csharp
{
    public class Utils
    {
        public static double ParseInput(string input)
        {
            double result;
            if (!double.TryParse(input, out result))
            {
                result = 0;
            }
            return result;
        }

        public static double CalculateBGCost(double w, double l, double cents)
        {
            return Math.Round(w * l * cents, 3);
        }
    }
}
