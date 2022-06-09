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
using WindowsStoreClone.Pages;
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Main _mainWindowContentPage;
        private TopAppsWrap _topAppsWrappedPage;
        public MainWindow()
        {
            InitializeComponent();
            _mainWindowContentPage = new Main();
            _mainWindowContentPage.AppClicked += MainWindowContentPage_AppClicked;
            _mainWindowContentPage.TopAppClicked += MainWindowContentPage_TopAppClicked;

            _topAppsWrappedPage = new TopAppsWrap();
            _topAppsWrappedPage.AppClicked += MainWindowContentPage_AppClicked;

            _topAppsWrappedPage.BackButtonClicked += AppDetails_BackButtonClicked;
        }

        private void MainWindowContentPage_TopAppClicked(object sender, RoutedEventArgs e)
        {
            TopAppsWrap page = new TopAppsWrap();
            page.AppClicked += MainWindowContentPage_AppClicked;
            page.BackButtonClicked += AppDetails_BackButtonClicked;
            MainWindowFrame.Content = page;
        }

        private void MainWindowContentPage_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppDetails appDetails = new AppDetails(sender);
            appDetails.BackButtonClicked += AppDetails_BackButtonClicked;
            appDetails.AppClicked += MainWindowContentPage_AppClicked;
            MainWindowFrame.Content = appDetails;
        }

        private void AppDetails_BackButtonClicked(object sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoBack)
            {
                MainWindowFrame.NavigationService.GoBack();
            }
        }

        private void MainWindowFrame_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = _mainWindowContentPage;

        }
    }
}
