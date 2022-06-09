using MiscUtil;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for HamburgerMenuApp.xaml
    /// </summary>
    public partial class HamburgerMenuApp : UserControl
    {
        public List<string> AppNames { get; set; }
        public List<string> AppTypes { get; set; }
        public string AppName { get; set; }
        public DateTime Purchased { get; set; }
        public string Type { get; set; }

        public HamburgerMenuApp()
        {
            InitializeComponent();
            AppTypes = new List<string>
            {
                "Apps", "Games", "Movies", "Avatars"
            };
            List<string> filePath =
                Directory.GetFiles(Environment.CurrentDirectory + @"\..\..\Images\MiniIcons", "*.png")
                .ToList();
            var fileInfo = new FileInfo(filePath[StaticRandom.Next(filePath.Count)]);
            AppName = fileInfo.Name.Split('.').First();
            Type = AppTypes[StaticRandom.Next(AppTypes.Count)];
            Purchased = new DateTime(2022, 6, StaticRandom.Next(1, DateTime.Now.Day + 1));

            AppImage.Source = new BitmapImage(
                new Uri(fileInfo.FullName, UriKind.RelativeOrAbsolute));
            AppNameLabel.Content = AppName;
            PurchasedLabel.Content = "Purchased " + Purchased.ToString("d");
        }
    }
}
