namespace CalculatorApp
{
    public partial class Form1 : Form
    {
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
    }
}
