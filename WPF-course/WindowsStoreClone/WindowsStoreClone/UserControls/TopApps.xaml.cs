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
    /// Interaction logic for TopApps.xaml
    /// </summary>
    public partial class TopApps : UserControl
    {
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public delegate void OnTopAppClicked(object sender, RoutedEventArgs e);
        public event OnTopAppClicked TopAppClicked;

        public TopApps()
        {
            InitializeComponent();
        }

        private void MainPic_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var image = sender as Image;
            AppClicked(new AnApp { AppName = image.Name, AppImageSource = image.Source }, e);
        }

        private void TopAppsButton_Click(object sender, RoutedEventArgs e)
        {
            TopAppClicked(sender, e);
        }
    }
}
