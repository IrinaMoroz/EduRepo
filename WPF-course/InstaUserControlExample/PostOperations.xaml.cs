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

namespace InstaUserControlExample
{
    /// <summary>
    /// Interaction logic for PostOperations.xaml
    /// </summary>
    public partial class PostOperations : UserControl
    {
        //TODO: Step 5: Add boolean property
        public bool PostLiked { get; set; }
        public PostOperations()
        {
            InitializeComponent();
        }
        //TODO: Step 6: Add like post method
        //All this does is just changes it from an unliked to liked
        public void LikePost()
        {
            Heart.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\..\..\Icons\like.png", UriKind.RelativeOrAbsolute));
            PostLiked = true;
        }
        //TODO: Step 7: Add like post method
        //All this does is just changes it from an liked to unliked
        public void UnLikePost()
        {
            Heart.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\..\..\Icons\nolike.png", UriKind.RelativeOrAbsolute));
            PostLiked = false;
        }
        //TODO: Step 8: Write the logic to like a post when it has not been liked
        //and unliked it when it is already liked
        //GOTO: MainWindow.xaml
        private void Heart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!PostLiked)
                LikePost();
            else
                UnLikePost();
        }
    }
}
