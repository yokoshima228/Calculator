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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private decimal firstNumber = 0;
        private string operation = "";
        private bool isNewOperation = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text == "0" || isNewOperation)
            {
                Display.Text = "";
                isNewOperation = false;
            }

            Button button = (Button)sender;
            Display.Text += button.Content.ToString();
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            firstNumber = decimal.Parse(Display.Text);
            operation = button.Content.ToString();
            isNewOperation = true;
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            decimal secondNumber = decimal.Parse(Display.Text);
            decimal result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "×":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "%":
                    result = firstNumber % secondNumber;
                    break;
                case "±":
                    result = firstNumber + secondNumber;
                    break;
            }

            Display.Text = result.ToString();
            isNewOperation = true;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
            firstNumber = 0;
            operation = "";
            isNewOperation = false;
        }

        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}