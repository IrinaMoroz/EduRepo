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
        private int scrrollItemsCount = 1;
        public List<AnApp> PresentedApps { get; private set; }
        public AppsViewer()
        {
            InitializeComponent();
            PresentedApps = new List<AnApp>();
            AppsList.ItemsSource = PresentedApps;
            for (int i = 0; i < 9; i++)
            {
                AnApp curr = new AnApp();
                PresentedApps.Add(curr);
            }
        }

        private void btnScrollLeft_Click(object sender, RoutedEventArgs e)
        {
            var widthOfOneApp = ((int)PresentedApps[0].ActualWidth) 
                + 2 * ((int)PresentedApps[0].Margin.Left);
            AppsScrollView.ScrollToHorizontalOffset(
                AppsScrollView.HorizontalOffset - scrrollItemsCount * widthOfOneApp);
        }

        private void btnScrollRight_Click(object sender, RoutedEventArgs e)
        {
            var widthOfOneApp = ((int)PresentedApps[0].ActualWidth)
                + 2 * ((int)PresentedApps[0].Margin.Left);
            AppsScrollView.ScrollToHorizontalOffset(
                AppsScrollView.HorizontalOffset + scrrollItemsCount * widthOfOneApp);
        }
    }
}
