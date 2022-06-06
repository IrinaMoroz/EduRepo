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
using System.Windows.Shapes;

namespace HelloWorldFr.EventlDemo
{
    /// <summary>
    /// Interaction logic for EventDemo.xaml
    /// </summary>
    public partial class EventDemo : Window
    {
        public EventDemo()
        {
            InitializeComponent();
            ValueController.MaxValueReached += (sender, e) => { MessageBox.Show("Max value reached"); };
            ValueController.MinValueReached += (sender, e) => { MessageBox.Show("Min value reached"); };
        }
    }
}
