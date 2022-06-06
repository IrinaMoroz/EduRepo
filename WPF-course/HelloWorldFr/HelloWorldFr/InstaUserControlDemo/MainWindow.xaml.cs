using HelloWorldFr.InstaUserControlDemo.UserControls;
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

namespace HelloWorldFr.InstaUserControlDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int verticalAdj = 400;

        public MainWindow()
        {
            InitializeComponent();
            MainStackPanel.Children.Add(new PicturePost());
            MainStackPanel.Children.Add(new PicturePost());
        }

        private void MainScroll_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (e.VerticalChange > 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (e.ViewportHeight + e.VerticalOffset + verticalAdj >= e.ExtentHeight)
                        MainStackPanel.Children.Add(new PicturePost());
                }
            }

        }
    }
}
