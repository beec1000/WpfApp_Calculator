using System.Linq;
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
    /*
    -Rejtett gombok működnek
    -(+;-;*;/;^) számolások működnek
    -Összes törlés/Karakterenkénti törlés működik
    -0-val való osztást kezeli
    -Van 2 mező a számítás megjelenítésére
    -Reszponzív az ablak
    -(√;.) gombok bugosak/nem működnek
    */
    public partial class MainWindow : Window
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private char operation;
        private HashSet<char> validOperator = new HashSet<char> { '-', '+', '*', '/', '^', '√' };

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
                if (MainScreen.Text == "0" && buttonText != ".")
                {
                    MainScreen.Clear();
                }
                MainScreen.Text += buttonText;
            }
        }
        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                char buttonText = button.Content.ToString()[0];

                if (validOperator.Contains(MainScreen.Text.LastOrDefault()))
                {
                    operation = buttonText;
                    MainScreen.Text = MainScreen.Text.Remove(MainScreen.Text.Length - 1) + buttonText;
                    return;
                }

                if (buttonText == '√')
                {
                    firstNumber = 0;
                    MainScreen.Text = "√";
                    return;
                }

                firstNumber = double.Parse(MainScreen.Text);
                operation = buttonText;
                MainScreen.Text += buttonText;
            }

        }
        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            if (validOperator.Contains(MainScreen.Text.LastOrDefault()))
            {
                return;
            }
            string[] parts = MainScreen.Text.Split(operation);
            if (parts.Length != 2)
            {
                // Invalid input format, do nothing
                return;
            }

            // Parse the second number
            secondNumber = double.Parse(parts[1]);

            double result = 0;
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '^':
                    result = Math.Pow(firstNumber, secondNumber);
                    break;
                case '√':
                    if (secondNumber >= 0)
                    {
                        result = Math.Sqrt(secondNumber);
                    }
                    else
                    {
                        MessageBox.Show("Cannot calculate square root of a negative number", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        MainScreen.Text = MainScreen.Text.Remove(MainScreen.Text.Length - 1);
                        return;
                    }
                    break;
                case '/':
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        MessageBox.Show("Hiba!!! 0-val való osztás", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        MainScreen.Text = MainScreen.Text.Remove(MainScreen.Text.Length - 1);
                        return;
                    }
                    break;
            }
            MainScreen.Text = result.ToString();
            SecondaryScreen.Text = result.ToString();
        }

        private void SingleClearB_Click(object sender, RoutedEventArgs e)
        {

            if (MainScreen.Text.Length > 0)
            {
                MainScreen.Text = MainScreen.Text.Substring(0, MainScreen.Text.Length - 1);
            }

            if (MainScreen.Text.Length == 0)
            {
                MainScreen.Text = "0";
            }
        }

        private void AllClearB_Click(object sender, RoutedEventArgs e)
        {
            MainScreen.Clear();
            MainScreen.Text = "0";
            SecondaryScreen.Clear();
            firstNumber = 0;
            secondNumber = 0;
        }

        private void Checked(object sender, RoutedEventArgs e)
        {
            btnSquareRoot.Visibility = Visibility.Visible;
            btnPower.Visibility = Visibility.Visible;
        }

        private void Unchecked(object sender, RoutedEventArgs e)
        {
            btnSquareRoot.Visibility = Visibility.Collapsed;
            btnPower.Visibility = Visibility.Collapsed;
        }
    }
}