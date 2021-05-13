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

namespace Calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float a = float.Parse(TextBox1.Text);
                float b = float.Parse(TextBox2.Text);
                float c = a + b;
                Label3.Content = TextBox1.Text + "+" + TextBox2.Text + "=" + c;
            }
            catch (FormatException f)
            {
                MessageBox.Show("Podaj liczbe");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                float a = float.Parse(TextBox1.Text);
                float b = float.Parse(TextBox2.Text);
                float c = a - b;
                Label3.Content = TextBox1.Text + "-" + TextBox2.Text + "=" + c;
            }
            catch (FormatException f)
            {
                MessageBox.Show("Podaj liczbe");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                float a = float.Parse(TextBox1.Text);
                float b = float.Parse(TextBox2.Text);
                float c = a * b;
                Label3.Content = TextBox1.Text + "*" + TextBox2.Text + "=" + c;
            }
            catch (FormatException f)
            {
                MessageBox.Show("Podaj liczbe");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                float a = float.Parse(TextBox1.Text);
                float b = float.Parse(TextBox2.Text);
                if (b != 0)
                {
                    float c = a / b;
                    Label3.Content = TextBox1.Text + "/" + TextBox2.Text + "=" + c;
                }
                else MessageBox.Show("Nie dziel przez 0");
            }
            catch(FormatException f)
            {
                MessageBox.Show("Podaj liczbe");
            }
        }
    }
}
