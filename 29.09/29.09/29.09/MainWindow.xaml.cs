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

namespace _29._09
{
    public partial class MainWindow : Window
    {
        private string correctCode = "12345";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string value = button.Content.ToString();
            if (value == "C")
                txtDisplay.Text = "";
            else if (value == "OK")
            {
                if (txtDisplay.Text == correctCode)
                    MessageBox.Show("Сейф открыт!");
                else
                    MessageBox.Show("Неверный код!");
            }
            else
                txtDisplay.Text += value;
        }
    }
}
