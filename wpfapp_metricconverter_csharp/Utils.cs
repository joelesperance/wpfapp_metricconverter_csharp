using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfapp_metricconverter_csharp
{
    public static class Utils
    {
        private static readonly int precision = 3;

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

        public static double ConvertToInches(double millimeter)
        {
            double inches = millimeter / 25.4;
            return Math.Round(inches, precision);
        }

        public static double ConvertToMillimeters(double millimeter)
        {
            double inches = millimeter * 25.4;
            return Math.Round(inches, precision);
        }

        public static double CalculateCrossCorner(double w, double l)
        {
            double crosscorner = Math.Sqrt((w * w) + (l * l));
            return Math.Round(crosscorner, precision);
        }

        public static double CalculateSteelNumber(double h, double w, double l)
        {
            return Math.Round(h * w * l * 0.283, precision);
        }
    }
}
