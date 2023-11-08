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
using System.Windows.Shapes;

namespace Portfolio
{
    /// <summary>
    /// Logika interakcji dla klasy Raports.xaml
    /// </summary>
    public partial class Raports : Window
    {
        private Window MainWindow;
        public Raports(Window window = null)
        {
            MainWindow = window;
            InitializeComponent();
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.Focus();
            MainWindow.Visibility = Visibility.Visible;
        }
        ///In raports you can download pdf Raports Day Week Month Year
    }
}
