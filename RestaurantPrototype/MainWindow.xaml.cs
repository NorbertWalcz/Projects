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

namespace RestaurantPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int suma { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            suma = 0;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = int.Parse(TextBox1.Text);
                if (a == 1) suma += 15;
                else if (a == 2) suma += 12;
                else if (a == 3) suma += 20;
                else if (a == 4) suma += 18;
                else if (a == 5) suma += 17;
                TextBox1.Text = "";
                Label.Content = "Cena" + suma + " zł";
            }
            catch (FormatException x)
            {
                MessageBox.Show("Wprowadz numer dania");
                TextBox1.Text = "";
            }
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            try
            {
                int b = int.Parse(TextBox2.Text);
                if (b == 1) suma += 6;
                else if (b == 2) suma += 6;
                else if (b == 3) suma += 4;
                else if (b == 4) suma += 3;
                TextBox2.Text = "";
                Label.Content = "Cena" + suma + " zł";
            }
            catch(FormatException x)
            {
                MessageBox.Show("Wprowadz numer dodatku");
                TextBox2.Text = "";
            }
        }

        
    }
}
