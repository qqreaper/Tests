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

namespace Tests
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Test1 test1 = new Test1();
            test1.Show();
        }


        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Test2 test2 = new Test2();
            test2.Show();
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
