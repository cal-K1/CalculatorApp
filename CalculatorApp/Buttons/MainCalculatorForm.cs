using CalculatorApp.Properties;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

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
                if (control is Button button)
                {
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
            // Append the number represented by the button's Text to the textbox
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
            foreach (Control gpbCalcMain in gpbCalcMain.Controls)
            {
                if (gpbCalcMain is Button button && button != btnCalcOnOff)
                {
                    if (onOffClicks % 2 == 0)
                    {
                        button.Enabled = false;
                        buttonMultiply.Image = Properties.Resources.DisabledMultiplictionImg;
                    }
                    else
                    {
                        button.Enabled = true;
                        buttonMultiply.Image = Properties.Resources.EnabledMultiplication;
                    }
                }
                else return;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string formattedCalculation = richTextBox1.Text.Replace("X", "*").ToString().Replace("÷", "/").Replace("π","3.14159265358979");

            try
            {
                richTextBox1.Text = new DataTable().Compute(formattedCalculation, null).ToString();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = "0";
            }
        }

    }
}


