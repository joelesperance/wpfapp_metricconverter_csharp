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
    /// Interaction logic for BGManual.xaml
    /// </summary>
    public partial class BGManual : UserControl
    {
        public BGManual()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            Cost1.Text = Utils.CalculateBGCost(Utils.ParseInput(WInches1.Text), Utils.ParseInput(LInches1.Text), Utils.ParseInput(Cents1.Text)).ToString("C");
            Cost2.Text = Utils.CalculateBGCost(Utils.ParseInput(WInches2.Text), Utils.ParseInput(LInches2.Text), Utils.ParseInput(Cents2.Text)).ToString("C");
            Cost3.Text = Utils.CalculateBGCost(Utils.ParseInput(WInches3.Text), Utils.ParseInput(LInches3.Text), Utils.ParseInput(Cents3.Text)).ToString("C");
            Cost4.Text = Utils.CalculateBGCost(Utils.ParseInput(WInches4.Text), Utils.ParseInput(LInches4.Text), Utils.ParseInput(Cents4.Text)).ToString("C");
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            WInches1.Text = "";
            WInches2.Text = "";
            WInches3.Text = "";
            WInches4.Text = "";
            LInches1.Text = "";
            LInches2.Text = "";
            LInches3.Text = "";
            LInches4.Text = "";
            Cost1.Text = "$0.00";
            Cost2.Text = "$0.00";
            Cost3.Text = "$0.00";
            Cost4.Text = "$0.00";
        }
    }
}
