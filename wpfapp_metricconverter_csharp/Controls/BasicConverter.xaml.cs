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
    /// Interaction logic for BasicConverter.xaml
    /// </summary>
    public partial class BasicConverter : UserControl
    {
        private readonly string placeholder = "0.000";

        public BasicConverter()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            inResult1.Text = Utils.ConvertToInches(Utils.ParseInput(mmBox1.Text)).ToString();
            inResult2.Text = Utils.ConvertToInches(Utils.ParseInput(mmBox2.Text)).ToString();
            inResult3.Text = Utils.ConvertToInches(Utils.ParseInput(mmBox3.Text)).ToString();
            inResult4.Text = Utils.ConvertToInches(Utils.ParseInput(mmBox4.Text)).ToString();

            mmResult1.Text = Utils.ConvertToMillimeters(Utils.ParseInput(inBox1.Text)).ToString();
            mmResult2.Text = Utils.ConvertToMillimeters(Utils.ParseInput(inBox2.Text)).ToString();
            mmResult3.Text = Utils.ConvertToMillimeters(Utils.ParseInput(inBox3.Text)).ToString();
            mmResult4.Text = Utils.ConvertToMillimeters(Utils.ParseInput(inBox4.Text)).ToString();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            mmBox1.Text = "";
            mmBox2.Text = "";
            mmBox3.Text = "";
            mmBox4.Text = "";
            inResult1.Text = placeholder;
            inResult2.Text = placeholder;
            inResult3.Text = placeholder;
            inResult4.Text = placeholder;
            inBox1.Text = "";
            inBox2.Text = "";
            inBox3.Text = "";
            inBox4.Text = "";
            mmResult1.Text = placeholder;
            mmResult2.Text = placeholder;
            mmResult3.Text = placeholder;
            mmResult4.Text = placeholder;
        }
    }
}
