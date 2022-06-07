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

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// Interaction logic for AnApp.xaml
    /// </summary>
    public partial class AnApp : UserControl
    {
        public string AppName { get; private set; }
        public ImageSource AppImageSource { get; private set; }
        public AnApp()
        {
            InitializeComponent();
            List<string> filePath = 
                Directory.GetFiles(Environment.CurrentDirectory +@"\..\..\Images", "*.png")
                .ToList();
            var fileInfo = new FileInfo(filePath[StaticRandom.Next(filePath.Count)]);
            AppImageSource = new BitmapImage(
                new Uri(fileInfo.FullName, UriKind.RelativeOrAbsolute));
            AppName = fileInfo.Name.Split('.').First();

            ProductImage.Source = AppImageSource;
            AppNameTxt.Text = AppName;
        }

        private void ProductImage_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
