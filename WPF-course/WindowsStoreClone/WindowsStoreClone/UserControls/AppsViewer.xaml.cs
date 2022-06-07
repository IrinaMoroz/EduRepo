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

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// Interaction logic for AppsViewer.xaml
    /// </summary>
    public partial class AppsViewer : UserControl
    {
        private const int scrrollItemsCount = 1;
        private List<AnApp> _presentedApps;

        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public AppsViewer()
        {
            InitializeComponent();
            _presentedApps = new List<AnApp>();
            AppsList.ItemsSource = _presentedApps;
            for (int i = 0; i < 9; i++)
            {
                AnApp curr = new AnApp();
                curr.AppClicked += CurrAppClicked;
                _presentedApps.Add(curr);
            }
        }

        private void CurrAppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }
        private void btnScrollLeft_Click(object sender, RoutedEventArgs e)
        {
            var widthOfOneApp = ((int)_presentedApps[0].ActualWidth) 
                + 2 * ((int)_presentedApps[0].Margin.Left);
            AppsScrollView.ScrollToHorizontalOffset(
                AppsScrollView.HorizontalOffset - scrrollItemsCount * widthOfOneApp);
        }

        private void btnScrollRight_Click(object sender, RoutedEventArgs e)
        {
            var widthOfOneApp = ((int)_presentedApps[0].ActualWidth)
                + 2 * ((int)_presentedApps[0].Margin.Left);
            AppsScrollView.ScrollToHorizontalOffset(
                AppsScrollView.HorizontalOffset + scrrollItemsCount * widthOfOneApp);
        }

        private void AppsScrollView_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            //fixies bug of unable to scroll if mouse over this UC
            e.Handled = true;
            var eventArgs = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
            eventArgs.RoutedEvent = UIElement.MouseWheelEvent;
            eventArgs.Source = sender;
            var parent = ((Control)sender).Parent as UIElement;
            parent.RaiseEvent(eventArgs);
        }
    }
}
