using System;

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
            return w * l * cents;
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

        public static double Calculate3DTime(double depth, double doc, double loc, double feed)
        {
            return Math.Round(((depth / doc) * loc) / feed, precision);
        }
    }
}
