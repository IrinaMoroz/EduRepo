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

namespace HelloWorldFr.DependencyPropertyDemo
{
    /// <summary>
    /// Interaction logic for MyUC.xaml
    /// </summary>
    public partial class MyUC : UserControl
    {
        public int Awesomness
        {
            get { return (int)GetValue(AwesomnessProperty); }
            set { SetValue(AwesomnessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Awesomness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AwesomnessProperty =
            DependencyProperty.Register("Awesomness", typeof(int), typeof(MyUC), new PropertyMetadata(0));


        public MyUC()
        {
            InitializeComponent();
        }
    }
}
