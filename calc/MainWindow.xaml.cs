using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Result.Text = string.Empty;
            Action.Text = string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = string.Empty;

            var button = sender as Button;
            var ButtonValue = button.Name[button.Name.Length - 1];
            Action.Text += ButtonValue;
        }

        private void Button_result_Click(object sender, RoutedEventArgs e)
        {
            var operation = Action.Text;

            Action.Text = Calculator(operation).ToString();
            Result.Text = Calculator(operation).ToString();
        }
        private bool IfContainsOperation(string operation)
            => operation.Contains('+') || operation.Contains('-') || operation.Contains('*') || operation.Contains('/');
        private int Calculator(string operation)
        {

            if (operation.Contains('+'))
            {
                var elements = operation.Split('+');

                return int.Parse(elements[0]) + int.Parse(elements[1]);
            }

            if (operation.Contains('-'))
            {
                var elements = operation.Split('-');

                return int.Parse(elements[0]) - int.Parse(elements[1]);
            }

            if (operation.Contains('/'))
            {
                var elements = operation.Split('/');

                return int.Parse(elements[0]) / int.Parse(elements[1]);
            }

            if (operation.Contains('*'))
            {
                var elements = operation.Split('*');

                return int.Parse(elements[0]) * int.Parse(elements[1]);
            }
            return default;
        }
        private void Button_multiply_Click(object sender, RoutedEventArgs e)
        {
            var operation = Action.Text;

            if (IfContainsOperation(operation))
            {
                Action.Text = Calculator(operation).ToString();
            }

            Action.Text += " * ";
        }
        private void Button_divide_Click(object sender, RoutedEventArgs e)
        {
            var operation = Action.Text;

             if (IfContainsOperation(operation))
            {
                Action.Text = Calculator(operation).ToString();
            }

            Action.Text += " / ";
        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            var operation = Action.Text;
            
            if (IfContainsOperation(operation))
            {
                Action.Text = Calculator(operation).ToString();
            }

            Action.Text += " - ";
        }

        private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            var operation = Action.Text;

            if(IfContainsOperation(operation))
            {
                Action.Text = Calculator(operation).ToString();
            }

            Action.Text += " + ";
        }

        private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = string.Empty;
            Action.Text = string.Empty;
        }
    }
}
