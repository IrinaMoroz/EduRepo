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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone.Pages
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public delegate void OnTopAppClicked(object sender, RoutedEventArgs e);
        public event OnTopAppClicked TopAppClicked;

        public Main()
        {
            InitializeComponent();
            DealsViewer.AppClicked += (sender, e) => { AppClicked(sender, e); };

            ucTopApps.AppClicked += AnApp_Click;
            ucTopApps.TopAppClicked += TopApp_Click;
            ProductivityAppsViewer.AppClicked += AnApp_Click;

            ProductivityBestSellingAppsViewer.AppClicked += AnApp_Click;
            ProductivitySpecialsAppsViewer.AppClicked    += AnApp_Click;
            EntertaimentTopFreeAppsViewer.AppClicked     += AnApp_Click;
            GamingTopFreeGamesViewer.AppClicked          += AnApp_Click;
            TopFreeGamesViewer.AppClicked                += AnApp_Click;
            TopFreeAppsViewer.AppClicked                 += AnApp_Click;
            MostPopularViewer.AppClicked                 += AnApp_Click;
            FeaturesAppsViewer.AppClicked                += AnApp_Click;

            HeaderRightButtons.DownloadButtonClicked += DowloadButton_Clicked;
        }

        private void DowloadButton_Clicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TopApp_Click(object sender, RoutedEventArgs e)
        {
            TopAppClicked(sender, e); 
        }

        private void AnApp_Click(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }

        private void MainScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            UIElement element = (UIElement)sender;
            element.Opacity = 0;
            DoubleAnimation animation = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(new TimeSpan(0, 0, 3))
            };
            element.BeginAnimation(UIElement.OpacityProperty, animation);

        }

        private void Page_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            HeaderRightButtons.MouseDown_OutsideOfHeaderRightButtons();
        }
    }
}
