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

namespace HelloWorldFr.PagesDemo
{
    /// <summary>
    /// Interaction logic for PagesWindow.xaml
    /// </summary>
    public partial class PagesWindow : Window
    {
        public Page1 Page1;
        public Page2 Page2;

        public PagesWindow()
        {
            InitializeComponent();
            Page1 = new Page1();
            Page2 = new Page2();
        }

        private void btnPage1_Click(object sender, RoutedEventArgs e)
        {
            WindowFrame.Content = Page1;
        }

        private void btnPage2_Click(object sender, RoutedEventArgs e)
        {
            WindowFrame.Content = Page2;

        }

        private void btnForth_Click(object sender, RoutedEventArgs e)
        {
            if (WindowFrame.NavigationService.CanGoBack)
            {
                WindowFrame.NavigationService.GoBack();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (WindowFrame.NavigationService.CanGoForward)
            {
                WindowFrame.NavigationService.GoForward();

            }
        }
    }
}
