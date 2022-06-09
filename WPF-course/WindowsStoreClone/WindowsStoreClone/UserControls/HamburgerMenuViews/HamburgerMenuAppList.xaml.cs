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
    /// Interaction logic for HumburgerMenuAppList.xaml
    /// </summary>
    public partial class HumburgerMenuAppList : UserControl
    {
        public List<HamburgerMenuApp> AllApps { get; set; }
        public List<HamburgerMenuApp> FilteredApps { get; set; }

        public HumburgerMenuAppList()
        {
            InitializeComponent();

            AllApps = new List<HamburgerMenuApp>();
            FilteredApps = new List<HamburgerMenuApp>();
            for (int i = 0; i < 15; i++)
            {
                AddNewHamApp();
            }
        }

        private void AddNewHamApp()
        {
            var app = new HamburgerMenuApp();
            MainStackPanel.Children.Add(app);
            AllApps.Add(app);
            FilteredApps.Add(app);
        }
        
        public void FilterByType(string filter)
        {
            var filtered = AllApps.Where(x => x.Type == filter).ToList();
            AddToStackPanel(filtered);
        }
        
        public void SortByName()
        {
            var sorted = FilteredApps.OrderBy(x => x.AppName).ToList();
            AddToStackPanel(sorted);
        }
        
        public void SortByDate()
        {
            var sorted = FilteredApps.OrderBy(x => x.Purchased).ToList();
            AddToStackPanel(sorted);
        }

        public void AddAll()
        {
            AddToStackPanel(AllApps);
        }

        private void AddToStackPanel(List<HamburgerMenuApp> apps)
        {
            MainStackPanel.Children.Clear();
            FilteredApps.Clear();
            foreach (var app in apps)
            {
                MainStackPanel.Children.Add(app);
                FilteredApps.Add(app);

            }
        }
    }
}
