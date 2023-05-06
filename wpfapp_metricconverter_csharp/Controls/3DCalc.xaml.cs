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
    /// Interaction logic for _3DCalc.xaml
    /// </summary>
    public partial class _3DCalc : UserControl
    {
        public _3DCalc()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            TimeBox.Text = Utils.Calculate3DTime(Utils.ParseInput(DepthBox.Text), Utils.ParseInput(DOCBox.Text), Utils.ParseInput(LOCBox.Text), Utils.ParseInput(FeedBox.Text)).ToString("");
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            DepthBox.Text = "";
            DOCBox.Text = "";
            LOCBox.Text = "";
            FeedBox.Text = "";
            TimeBox.Text = "";
        }
    }
}
