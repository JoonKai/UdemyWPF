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

namespace _05_DelegatesAndEventsDemo
{
    /// <summary>
    /// ValueUC.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ValueUC : UserControl
    {
        public delegate void OnMinThresHoldReached(object sender, RoutedEventArgs e);
        public event OnMinThresHoldReached MinThresholdReached;
        public delegate void OnMaxThresHoldReached(object sender, RoutedEventArgs e);
        public event OnMaxThresHoldReached MaxThresholdReached;

        public ValueUC()
        {
            InitializeComponent();
        }

        private void Minus_Button_Click(object sender, RoutedEventArgs e)
        {
            ValueLabel.Text = (Int32.Parse(ValueLabel.Text) - 10).ToString();
        }

        private void Plus_Button_Click(object sender, RoutedEventArgs e)
        {
            ValueLabel.Text = (Int32.Parse(ValueLabel.Text) + 10).ToString();
        }

        private void ValueLabel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Int32.Parse((sender as TextBox).Text) < 0)
            {
                (sender as TextBox).Text = "0";
                MinThresholdReached(sender, e);
            }
            if(Int32.Parse((sender as TextBox).Text) > 100)
            {
                (sender as TextBox).Text = "100";
                MaxThresholdReached(sender, e);
            }
        }
    }
}
