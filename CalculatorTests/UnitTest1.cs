using CalculatorApp.Helpers;
using Xunit;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Fact]
        public void CalculatorAppHelpers_FormatString_ReturnsString()
        {
            // Arrange
            string inputStringOne = "2+2";
            string inputStringTwo = "5²-6";
            string inputStringThree = "5²+2X4÷2π-9";
            string inputStringFour = "÷5";

            string expectedFormattedStringOne = "2+2";
            string expectedFormattedStringTwo = "25-6";
            string expectedFormattedStringThree = "25+12.56637061435916-9";
            string expectedFormattedStringFour = "Error";

            // Act
            string formattedStringOne = CalculatorHelper.FormatString(inputStringOne);
            string formattedStringTwo = CalculatorHelper.FormatString(inputStringTwo);
            string formattedStringThree = CalculatorHelper.FormatString(inputStringThree);
            string formattedStringFour = CalculatorHelper.FormatString(inputStringFour);

            // Assert
            Assert.Equal(expectedFormattedStringOne, formattedStringOne);
            Assert.Equal(expectedFormattedStringTwo, formattedStringTwo);
            Assert.Equal(expectedFormattedStringThree, formattedStringThree);
            Assert.Equal(expectedFormattedStringFour, formattedStringFour);

        }
    }
}