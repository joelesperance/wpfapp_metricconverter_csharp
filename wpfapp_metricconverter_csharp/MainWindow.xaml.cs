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

namespace wpfapp_metricconverter_csharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly int precision = 3;
        private readonly string placeholder = "0.000";
        public MainWindow()
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

            WInchesTextBox1.Text = wInches.ToString();
            WInchesTextBox2.Text = wInches.ToString();
            WInchesTextBox3.Text = wInches.ToString();
            WInchesTextBox4.Text = wInches.ToString();
            LInchesTextBox1.Text = lInches.ToString();
            LInchesTextBox2.Text = lInches.ToString();
            LInchesTextBox3.Text = lInches.ToString();
            LInchesTextBox4.Text = lInches.ToString();

            Cost1.Text = CalculateBGCost(wInches, lInches, Utils.ParseInput(Cents1.Text)).ToString("C");
            Cost2.Text = CalculateBGCost(wInches, lInches, Utils.ParseInput(Cents2.Text)).ToString("C");
            Cost3.Text = CalculateBGCost(wInches, lInches, Utils.ParseInput(Cents3.Text)).ToString("C");
            Cost4.Text = CalculateBGCost(wInches, lInches, Utils.ParseInput(Cents4.Text)).ToString("C");
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            HMilTextBox.Text = "";
            WMilTextBox.Text = "";
            LMilTextBox.Text = "";
            HInchesTextBox.Text = placeholder;
            WInchesTextBox.Text = placeholder;
            LInchesTextBox.Text = placeholder;
            CCInches.Text = placeholder;
            CCMil.Text = placeholder;
            StInches.Text = placeholder;
            StMil.Text = placeholder;
            WInchesTextBox1.Text = placeholder;
            WInchesTextBox2.Text = placeholder;
            WInchesTextBox3.Text = placeholder;
            WInchesTextBox4.Text = placeholder;
            LInchesTextBox1.Text = placeholder;
            LInchesTextBox2.Text = placeholder;
            LInchesTextBox3.Text = placeholder;
            LInchesTextBox4.Text = placeholder;
            Cost1.Text = "$0.00";
            Cost2.Text = "$0.00";
            Cost3.Text = "$0.00";
            Cost4.Text = "$0.00";
        }

        #region Helper Methods
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

        private double CalculateBGCost(double w, double l, double cents)
        {
            return Math.Round(w * l * cents, precision);
        }
        #endregion
    }
}
