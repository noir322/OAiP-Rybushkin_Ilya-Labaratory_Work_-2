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

namespace lab_6
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(value.Text);
            int i;
            i = x * x + 4 * x + 5;
            string stri = Convert.ToString(i);
            MessageBox.Show(stri);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(second_solution.Text);
            int b;
            b = a * a + 4 * a + 5;
            string strb = Convert.ToString(b);
            MessageBox.Show($" 1\r\n---\r\n{strb}");
        }
    }
}
