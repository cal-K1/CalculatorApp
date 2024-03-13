using CalculatorApp.Properties;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        bool wasLastClickEquals; 
        int onOffClicks = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeNumberButtons();
        }

        private void InitializeNumberButtons()
        {
            WasLastClickEquals();
            // Iterate through all controls in the form
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    if (int.TryParse(button.Text, out int number))
                    {
                        // Assign the same event handler to each number button's Click event
                        button.Click += NumberButton_Click;
                        wasLastClickEquals = false;
                    }
                }
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            WasLastClickEquals();

            // Append the number represented by the button's Text to the textbox
            richTextBoxCalculatorDisplay.Text += ((Button)sender).Text;
            wasLastClickEquals = false;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            WasLastClickEquals();

            richTextBoxCalculatorDisplay.Text = string.Empty;
            btnDecimal.Enabled = true;
            wasLastClickEquals = false;
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            WasLastClickEquals();

            richTextBoxCalculatorDisplay.Text += "π";
            wasLastClickEquals = false;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            WasLastClickEquals();

            richTextBoxCalculatorDisplay.Text += ".";
            btnDecimal.Enabled = false;
            wasLastClickEquals = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WasLastClickEquals();

            if (richTextBoxCalculatorDisplay.Text.EndsWith("."))
            {
                btnDecimal.Enabled = true;
            }

            try
            {
                richTextBoxCalculatorDisplay.Text = richTextBoxCalculatorDisplay.Text.Remove(richTextBoxCalculatorDisplay.Text.Length - 1);
            }
            catch
            {
                return;
            }
            wasLastClickEquals = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WasLastClickEquals();

            richTextBoxCalculatorDisplay.Text += "+";
            btnDecimal.Enabled = true;
            wasLastClickEquals = false;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            WasLastClickEquals();

            richTextBoxCalculatorDisplay.Text += "-";
            btnDecimal.Enabled = true;
            wasLastClickEquals = false;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            WasLastClickEquals();

            richTextBoxCalculatorDisplay.Text += "*";
            btnDecimal.Enabled = true;
            wasLastClickEquals = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            WasLastClickEquals();

            richTextBoxCalculatorDisplay.Text += "÷";
            btnDecimal.Enabled = true;
            wasLastClickEquals = false;
        }

        private void btnSquared_Click(object sender, EventArgs e)
        {
            WasLastClickEquals();

            richTextBoxCalculatorDisplay.Text += "²";
            wasLastClickEquals = false;
        }

        private void btnCalcOnOff_Click(object sender, EventArgs e)
        {
            WasLastClickEquals();

            onOffClicks++;
            foreach (Control gpbCalcMain in gpbCalcMain.Controls)
            {
                if (gpbCalcMain is Button button && button != btnCalcOnOff)
                {
                    if (onOffClicks % 2 == 0)
                    {
                        button.Enabled = false;
                        richTextBoxCalculatorDisplay.Text = string.Empty;
                    }
                    else
                    {
                        button.Enabled = true;
                    }
                }
                else return;
            }
            wasLastClickEquals = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            WasLastClickEquals();

            string formattedCalculation = richTextBoxCalculatorDisplay.Text.Replace("X", "*").Replace("÷", "/").Replace("π", "3.14159265358979");

            try
            {
                // Handle squared expressions
                if (formattedCalculation.Contains("²"))
                {
                    // Extract the base number
                    string baseNumberStr = Regex.Match(formattedCalculation, @"\d+").Value;
                    double baseNumber = double.Parse(baseNumberStr);

                    double result = Math.Pow(baseNumber, 2);

                    formattedCalculation = formattedCalculation.Replace($"{baseNumberStr}²", result.ToString());
                }

                richTextBoxCalculatorDisplay.Text = new DataTable().Compute(formattedCalculation, null).ToString();
            }
            catch (Exception ex)
            {
                richTextBoxCalculatorDisplay.Text = "Error";
            }
            wasLastClickEquals = true;
        }
        public void WasLastClickEquals()
        {
            if (wasLastClickEquals == true)
            {
                richTextBoxCalculatorDisplay.Text = string.Empty;
            }
            else return;
        }
    }
}


