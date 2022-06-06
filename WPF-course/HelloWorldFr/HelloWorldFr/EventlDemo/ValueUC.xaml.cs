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

namespace HelloWorldFr.EventlDemo
{
    /// <summary>
    /// Interaction logic for ValueUC.xaml
    /// </summary>
    public partial class ValueUC : UserControl
    {
        public delegate void OnMinValueReached(object sender, RoutedEventArgs e);
        public delegate void OnMaxValueReached(object sender, RoutedEventArgs e);
        public event OnMinValueReached MinValueReached;
        public event OnMaxValueReached MaxValueReached;

        public ValueUC()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ValueLabel.Text = (Int32.Parse(ValueLabel.Text) + 10).ToString();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            ValueLabel.Text = (Int32.Parse(ValueLabel.Text) - 10).ToString();
        }

        private void ValueLabel_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;

            if(Int32.Parse(tb.Text) == 0)
            {
                MinValueReached(sender, e);
            }
            if(Int32.Parse(tb.Text) == 100)
            {
                MaxValueReached(sender, e);
            }
        }
    }
}
