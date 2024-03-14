using Xunit;
using CalculatorApp;

namespace CalculatorAppUnitTests.Tests
{
    public class Form1UnitTests
    {
        private readonly Form1 form;

        public Form1UnitTests()
        {
            form = new Form1();
        }

        [Fact]
        public void NumberButton_Click_AppendsNumberToTextBox()
        {
            // Arrange
            Button button = new Button();
            button.Text = "1";
            form.richTextBoxCalculatorDisplay.Text = "";

            // Act
            form.NumberButton_Click(button, EventArgs.Empty);

            // Assert
            Assert.Equal("1", form.richTextBoxCalculatorDisplay.Text);
        }
    }
}
