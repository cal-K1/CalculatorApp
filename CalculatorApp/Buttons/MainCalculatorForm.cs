using System.Text;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {

        int onOffClicks = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeNumberButtons();
        }

        private void InitializeNumberButtons()
        {
            // Iterate through all controls in the form
            foreach (Control control in Controls)
            {
                // Check if the control is a Button
                if (control is Button button)
                {
                    // Check if the button's Text represents a number
                    if (int.TryParse(button.Text, out int number))
                    {
                        // Assign the same event handler to each number button's Click event
                        button.Click += NumberButton_Click;
                    }
                }
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            // Append the number represented by the button's Text to the richTextBox
            richTextBox1.Text += ((Button)sender).Text;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            btnDecimal.Enabled = true;
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "π";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ".";
            btnDecimal.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.EndsWith("."))
            {
                btnDecimal.Enabled = true;
            }

            try
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
            }
            catch
            {
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
            btnDecimal.Enabled = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "-";
            btnDecimal.Enabled = true;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "*";
            btnDecimal.Enabled = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "÷";
            btnDecimal.Enabled = true;
        }

        private void btnSquared_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "²";
        }

        private void btnCalcOnOff_Click(object sender, EventArgs e)
        {
            onOffClicks++;
            foreach (Control gpbCalcMain in gpbCalcMain.Controls) // Replace groupBox1 with the name of your GroupBox
            {
                if (gpbCalcMain is Button button && button != btnCalcOnOff)
                {
                    if (onOffClicks % 2 == 0)
                    {
                        button.Enabled = false;
                    }
                    else
                    {
                        button.Enabled = true;
                    }
                }
                else return;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string expression = richTextBox1.Text;

            // Split the expression into tokens using the operators as delimiters
            string[] tokens = expression.Split(new char[] { '+', '-', '*', '/' });

            // Define an empty list to store numbers
            List<double> numbers = new List<double>();

            // Define an empty list to store operators
            List<char> operators = new List<char>();

            // Parse each token and categorize them as numbers or operators
            foreach (string token in tokens)
            {
                double number;
                if (double.TryParse(token, out number))
                {
                    numbers.Add(number);
                }
                else if (!string.IsNullOrWhiteSpace(token))
                {
                    // Assuming the token is an operator
                    operators.Add(token[0]);
                }
            }

            // Initialize the result with the first number
            double result = numbers[0];

            // Iterate through the operators and perform the corresponding operation with the next number
            for (int i = 0; i < operators.Count; i++)
            {
                switch (operators[i])
                {
                    case '+':
                        result += numbers[i + 1];
                        break;
                    case '-':
                        result -= numbers[i + 1];
                        break;
                    case '*':
                        result *= numbers[i + 1];
                        break;
                    case '/':
                        result /= numbers[i + 1];
                        break;
                }
            }

            // Display the result
            richTextBox1.Text = result.ToString();
        }

    }
}

