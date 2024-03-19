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
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string buttonText = button.Content.ToString();
                if (MainScreen.Text == 0.ToString())
                {
                    MainScreen.Clear();
                }
                MainScreen.Text += buttonText;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            MainScreen.Clear();
            MainScreen.Text += 0.ToString();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (!MainScreen.Text.Any(char.IsDigit) || MainScreen.Text.EndsWith("-") || MainScreen.Text.EndsWith("+") || MainScreen.Text.EndsWith("*") || MainScreen.Text.EndsWith("/"))
            {
                return;
            }
            MainScreen.Text += "+";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (!MainScreen.Text.Any(char.IsDigit) || MainScreen.Text.EndsWith("-") || MainScreen.Text.EndsWith("+") || MainScreen.Text.EndsWith("*") || MainScreen.Text.EndsWith("/"))
            {
                return;
            }
            MainScreen.Text += "-";
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
          SecondaryScreen.Text = MainScreen.Text;
        }
    }
}