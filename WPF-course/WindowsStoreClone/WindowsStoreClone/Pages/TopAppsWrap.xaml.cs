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
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone.Pages
{
    /// <summary>
    /// Interaction logic for TopAppsWrap.xaml
    /// </summary>
    public partial class TopAppsWrap : Page
    {
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;

        public TopAppsWrap()
        {
            InitializeComponent();
            GenerateApps(12);
        }

        private void CurrentApp_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            BackButtonClicked(sender, e);
        }

        private void TopAppsWrapScroll_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            //infinite scrolling
            if (e.VerticalChange > 0)
            {
                int adj = 400;
                if (e.VerticalOffset + e.ViewportHeight + adj >= e.ExtentHeight)
                {
                    GenerateApps(6);
                }
            }
        }

        private void GenerateApps(int appsCount)
        {
            for (int i = 0; i < appsCount; i++)
            {
                var currentApp = new AnApp();
                currentApp.AppClicked += CurrentApp_AppClicked;
                TopAppsWrapPageWrapPanel.Children.Add(currentApp);
            }
        }
    }
}
