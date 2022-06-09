using MiscUtil;
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

namespace WindowsStoreClone.UserControls.AppDetailsTabContent
{
    /// <summary>
    /// Interaction logic for Review.xaml
    /// </summary>
    public partial class Review : UserControl
    {
        List<string> Names;
        public Review()
        {
            InitializeComponent();
            Names = new List<string> { "Victoria", "Mike", "Maria", "John" };
            var name = Names[StaticRandom.Next(Names.Count)];
            ReviewNameLabel.Content = name;
            AvatarLabel.Content = name.First();
            StartLabel.Content = "***";
            if (name == "Victoria") StartLabel.Content = "*";
            ReviewTitle.Content = name == "Victoria" ? "Total disapointment" : "This is okay";
        }
         
    }
}
