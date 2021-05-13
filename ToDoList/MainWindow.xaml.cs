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
using Microsoft.Win32;
using System.IO;


namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int NumberOfTask { get; private set; }
        public List <TextBlock> tasks = new List<TextBlock>();
        public MainWindow()
        {
            InitializeComponent();
            NumberOfTask = 0;
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if (NumberOfTask == 0) MessageBox.Show("There is no task");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.TextBlock _newtextblock = new TextBlock();
            _newtextblock.Text = textbox1.Text;
            _newtextblock.Background = Brushes.Red;
            stackpanel1.Children.Add(_newtextblock);
            NumberOfTask++;
            tasks.Add(_newtextblock);
            MessageBox.Show(_newtextblock.Text);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var win2 = new Window2();
            win2.Show();
            //this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show(tasks[0].Text);  wskazówka jak przenosić pliki
        }
    }

    
}
