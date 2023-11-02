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

namespace Portfolio
{
    
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void Calendar(object sender, RoutedEventArgs e)
        {
            Window calendar = new Calendar(this);
            calendar.Show();
            calendar.Focus();
            Visibility = Visibility.Hidden;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Events(object sender, RoutedEventArgs e)
        {
            ///Add new Window Events
            ///Add goto Events
            ///show event payment and caliber to raports and calendar
        }

        private void Raports(object sender, RoutedEventArgs e)
        {
            ///Add new Window Raports
            ///Add goto Raports
            ///In raports you can download pdf Raports Day Week Month Year
        }
    }
}
