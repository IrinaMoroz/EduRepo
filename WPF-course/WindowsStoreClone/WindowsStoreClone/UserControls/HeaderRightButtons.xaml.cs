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
    /// Interaction logic for HeaderRightButtons.xaml
    /// </summary>
    public partial class HeaderRightButtons : UserControl
    {
        public delegate void OnDownloadButtonClicked(object sender, RoutedEventArgs e);
        public event OnDownloadButtonClicked DownloadButtonClicked;
        public HeaderRightButtons()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Collapsed;
            SearchTextBox.Visibility = Visibility.Visible;
        }

        public void MouseDown_OutsideOfHeaderRightButtons()
        {
            if (!SearchTextBox.IsMouseOver)
            {
                SearchButton.Visibility = Visibility.Visible;
                SearchTextBox.Visibility = Visibility.Collapsed;
            }
        }

        private void Download_Click(object sender, RoutedEventArgs e)
        {
            DownloadButtonClicked(sender,e);
        }

        private void DownloadAndUpdate_Click(object sender, RoutedEventArgs e)
        {
            DownloadButtonClicked(sender, e);
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
