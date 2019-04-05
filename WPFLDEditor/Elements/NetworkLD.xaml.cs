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

namespace WPFNetwork
{
    /// <summary>
    /// Логика взаимодействия для NetworkControl.xaml
    /// </summary>
    public partial class NetworkControl : UserControl
    {
        public NetworkControl()
        {
            InitializeComponent();
        }

  


        private void Line_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            


        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Line_GotFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выбрана сеть");

        }
    }
}
