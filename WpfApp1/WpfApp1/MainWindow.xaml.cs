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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double A=0, B=0, Res = 0;

        private void mns_Click(object sender, RoutedEventArgs e)
        {
            A = double.Parse(a.Text);
            B = double.Parse(b.Text);
            Res = A - B;
            res.Text = Res.ToString();
        }

        private void umn_Click(object sender, RoutedEventArgs e)
        {
            A = double.Parse(a.Text);
            B = double.Parse(b.Text);
            Res = A * B;
            res.Text = Res.ToString();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            A = double.Parse(a.Text);
            B = double.Parse(b.Text);
            Res = A / B;
            res.Text = Res.ToString();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void pls_Click(object sender, RoutedEventArgs e)
        {
            A = double.Parse(a.Text);
            B = double.Parse(b.Text);
            Res = A + B;
            res.Text = Res.ToString();
        }
    }
}
