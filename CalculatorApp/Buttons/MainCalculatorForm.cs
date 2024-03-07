namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
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
    }
}
