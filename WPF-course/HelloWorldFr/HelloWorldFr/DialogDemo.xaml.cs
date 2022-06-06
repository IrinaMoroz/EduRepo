using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace HelloWorldFr
{
    /// <summary>
    /// Interaction logic for DialogDemo.xaml
    /// </summary>
    public partial class DialogDemo : Window
    {
        public DialogDemo()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();
            opDialog.InitialDirectory = System.IO.Path.GetFullPath(Environment.CurrentDirectory + @"\..\..\..");
            opDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            var res = opDialog.ShowDialog();
            if (res.HasValue && res.Value)
            {
                tbContent.Text = File.ReadAllText(opDialog.FileName);
            }
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = System.IO.Path.GetFullPath(Environment.CurrentDirectory + @"\..\..\..");
            saveDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveDialog.FileName, tbContent.Text);
            }
        }
    }
}
