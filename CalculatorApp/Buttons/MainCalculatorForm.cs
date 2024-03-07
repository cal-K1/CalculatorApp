namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void NumberButtonClick(Button sender, EventArgs e)
        {
            Button button = (Button)sender;
            richTextBox1.Text += button.Text;
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
