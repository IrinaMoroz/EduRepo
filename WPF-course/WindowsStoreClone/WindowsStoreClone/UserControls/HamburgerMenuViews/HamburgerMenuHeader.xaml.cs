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

namespace WindowsStoreClone.UserControls.HamburgerMenuViews
{
    /// <summary>
    /// Interaction logic for HamburgerMenuHeader.xaml
    /// </summary>
    public partial class HamburgerMenuHeader : UserControl
    {
        public delegate void OnFilterClicked(object sender, RoutedEventArgs e);
        public event OnFilterClicked FilterClicked;

        public delegate void OnSortByClicked(object sender, RoutedEventArgs e);
        public event OnSortByClicked SortByClicked;

        public HamburgerMenuHeader()
        {
            InitializeComponent();
        }

        private void FilterMenuItem_Click(object sender, RoutedEventArgs e)
        {
            FilterByLabel.Content = (sender as MenuItem).Header.ToString();
            FilterClicked(sender, e);
        }

        private void SortByMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SortByLabel.Content = (sender as MenuItem).Header.ToString();
            SortByClicked(sender, e);

        }
    }
}
