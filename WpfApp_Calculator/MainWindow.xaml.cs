using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Calculator
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            MainScreen.Clear();
            MainScreen.Text += "0";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (MainScreen.Text == "0")
            {
                MainScreen.Clear();
            }
            MainScreen.Text += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (MainScreen.Text == "0")
            {
                MainScreen.Clear();
            }
            MainScreen.Text += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (MainScreen.Text == "0")
            {
                MainScreen.Clear();
            }
            MainScreen.Text += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (MainScreen.Text == "0")
            {
                MainScreen.Clear();
            }
            MainScreen.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if(MainScreen.Text == "0")
            {
                MainScreen.Clear();
            }
            MainScreen.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (MainScreen.Text == "0")
            {
                MainScreen.Clear();
            }
            MainScreen.Text += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (MainScreen.Text == "0")
            {
                MainScreen.Clear();
            }
            MainScreen.Text += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (MainScreen.Text == "0")
            {
                MainScreen.Clear();
            }
            MainScreen.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (MainScreen.Text == "0")
            {
                MainScreen.Clear();
            }
            MainScreen.Text += "9";
        }

        private void bnt0_Click(object sender, RoutedEventArgs e)
        {
            if (MainScreen.Text != "0")
            {
                MainScreen.Text += "0";
            }
        }
    }
}