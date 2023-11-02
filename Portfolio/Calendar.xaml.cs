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
using System.Windows.Threading;

namespace Portfolio
{
    /// <summary>
    /// Logika interakcji dla klasy Calendar.xaml
    /// </summary>
    
    public partial class Calendar : Window
    {
        private Window MainWindow;
        public Calendar(Window window = null)
        {
            MainWindow = window;
            InitializeComponent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.Focus();
            MainWindow.Visibility = Visibility.Visible;
        }

        

        private void Main_Menu(object sender, RoutedEventArgs e)
        {
            MainWindow.Focus();
            MainWindow.Visibility= Visibility.Visible;
            Close();
        }

        ///Add calendar
        ///Conect to Events and Raports 
        ///we cant do anytching about calendar only see whoat type of payments calendar is monthly

       
    }
}
