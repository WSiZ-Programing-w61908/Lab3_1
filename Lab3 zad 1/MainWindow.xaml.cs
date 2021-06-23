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

namespace Lab3_zad_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString("Suma: " + a + "+" + b + "=" + (a + b));
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString("Różnica: " + a + "-" + b + "=" + (a - b));
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString("Iloczyn: " + a + "*" + b + "=" + (a * b));
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            if (b == 0)
            {
                textBox3.Text = "Nie dziel przez 0!";
                MessageBox.Show("Nie dziel przez 0");
            }
            else
            {
                textBox3.Text = Convert.ToString("Iloraz: " + a + ":" + b + "=" + (a / b));
            }
        }
    }
}
