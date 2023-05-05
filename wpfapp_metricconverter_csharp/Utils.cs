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
    }
}
