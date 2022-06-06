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

namespace HelloWorldFr.InstaUserControlDemo.UserControls
{
    /// <summary>
    /// Interaction logic for PostOperationsUC.xaml
    /// </summary>
    public partial class PostOperationsUC : UserControl
    {
        public bool PostLiked { get; set; }
        public PostOperationsUC()
        {
            InitializeComponent();
        }

        public void LikePost()
        {
            PostLiked = true;
            Heart.Source = new BitmapImage(new Uri(Environment.CurrentDirectory+ @"\..\..\InstaUserControlDemo\Icons\like.png", UriKind.RelativeOrAbsolute));
        }
        public void UnLikePost()
        {
            PostLiked = false;
            Heart.Source = new BitmapImage(new Uri(
                Environment.CurrentDirectory+ @"\..\..\InstaUserControlDemo\Icons\nolike.png", UriKind.RelativeOrAbsolute));
        }
        private void Heart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!PostLiked)
            {
                LikePost();
            }
            else
            {
                UnLikePost();
            }
        }
    }
}
