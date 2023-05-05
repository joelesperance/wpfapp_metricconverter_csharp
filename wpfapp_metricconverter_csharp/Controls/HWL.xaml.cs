using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfapp_metricconverter_csharp.Controls
{
    /// <summary>
    /// Interaction logic for HWL.xaml
    /// </summary>
    public partial class HWL : UserControl
    {
        private int precision = 3;
       
        public HWL()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            double hMil = Utils.ParseInput(HMilTextBox.Text);
            double wMil = Utils.ParseInput(WMilTextBox.Text);
            double lMil = Utils.ParseInput(LMilTextBox.Text);

            double hInches = ConvertToInches(hMil);
            double wInches = ConvertToInches(wMil);
            double lInches = ConvertToInches(lMil);

            HInchesTextBox.Text = hInches.ToString();
            WInchesTextBox.Text = wInches.ToString();
            LInchesTextBox.Text = lInches.ToString();
            CCInches.Text = CalculateCrossCorner(wInches, lInches).ToString();
            CCMil.Text = CalculateCrossCorner(wMil, lMil).ToString();
            StInches.Text = CalculateSteelNumber(hInches, wInches, lInches).ToString();
            StMil.Text = CalculateSteelNumber(hMil, wMil, lMil).ToString();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            HMilTextBox.Text = "0";
            WMilTextBox.Text = "0";
            LMilTextBox.Text = "0";
            HInchesTextBox.Text = "0";
            WInchesTextBox.Text = "0";
            LInchesTextBox.Text = "0";
            CCInches.Text = "0";
            CCMil.Text = "0";
            StInches.Text = "0";
            StMil.Text = "0";
        }

        private double ConvertToInches(double millimeter)
        {
            double inches = millimeter / 25.4;
            return Math.Round(inches, precision);
        }

        private double CalculateCrossCorner(double w, double l)
        {
            double crosscorner = Math.Sqrt((w * w) + (l * l));
            return Math.Round(crosscorner, precision);
        }

        private double CalculateSteelNumber(double h, double w, double l)
        {
            return Math.Round(h * w * l * 0.283, precision);
        }
    }
}
