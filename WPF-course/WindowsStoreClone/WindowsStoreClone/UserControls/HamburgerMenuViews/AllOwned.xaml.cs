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
    /// Interaction logic for AllOwned.xaml
    /// </summary>
    public partial class AllOwned : UserControl
    {
        public delegate void OnFilterClicked(object sender, RoutedEventArgs e);
        public event OnFilterClicked FilterClicked;

        public delegate void OnSortByClicked(object sender, RoutedEventArgs e);
        public event OnSortByClicked SortByClicked;

        public AllOwned()
        {
            InitializeComponent();
            HamHeader.FilterClicked += HamburgerMenuHeader_FilterClicked;
            HamHeader.SortByClicked += HamburgerMenuHeader_SortByClicked;
        }

        private void HamburgerMenuHeader_FilterClicked(object sender, RoutedEventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem.Header.ToString().ToLower() == "all types")
            {
                HamAppList.AddAll();
            }
            else
            {
                HamAppList.FilterByType(menuItem.Header.ToString());
            }
        }

        private void HamburgerMenuHeader_SortByClicked(object sender, RoutedEventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem.Header.ToString().ToLower() == "sort by name")
            {
                HamAppList.SortByName();
            }
            else
            {
                HamAppList.SortByDate();
            }
        }
    }
}
