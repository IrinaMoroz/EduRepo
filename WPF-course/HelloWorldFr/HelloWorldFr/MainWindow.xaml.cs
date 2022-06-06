using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HelloWorldFr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<int> Numbers { get; set; }
        public MainWindow()
        {
            Numbers = new ObservableCollection<int>(Enumerable.Range(1, 10));
            InitializeComponent();
        }

        private void CreateCustomTextBlock()
        {
            var myTb = new TextBlock();
            myTb.Text = "This is hello word";
            myTb.Foreground = Brushes.Violet;
            myTb.Inlines.Add(new LineBreak());
            myTb.Inlines.Add(new Run(" New text")
            {
                Foreground = Brushes.GreenYellow,
                TextDecorations = TextDecorations.Strikethrough
            });

            this.Content = myTb;
        }
        private void Hyperlink_GoToUrl(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            btnLabel.FontSize = ++btnLabel.FontSize;
            sizeLbl.Content = btnLabel.FontSize;
        }

        private void menuMakeBold_Click(object sender, RoutedEventArgs e)
        {
            tbMenu.FontWeight = FontWeights.Bold;
        }

        private void lbAdd_Click(object sender, RoutedEventArgs e)
        {
            Numbers.Add(1);
        }

        private void lbDelete_Click(object sender, RoutedEventArgs e)
        {
            Numbers.RemoveAt(0);
        }
    }
}
