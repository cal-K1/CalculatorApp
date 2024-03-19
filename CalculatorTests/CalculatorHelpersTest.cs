using CalculatorApp.Helpers;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorHelpersTest
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
            string expectedFormattedStringThree = "25+2*4/2*3.141592653589793-9";
            string expectedFormattedStringFour = "/5";

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

        [Fact]
        public void CalculatorAppHelpers_Calculate_ReturnsString()
        {
            // Arrange
            string inputExpressionOne = "2+2";
            string inputExpressionTwo = "25-6";
            string inputExpressionThree = "25+2*4/2*3.141592653589793-9";
            string inputExpressionFour = "/5";
            string inputExpressionFive = "23.12*0.0012*3.141592653589793";

            string expectedCalculatedValueOne = "4";
            string expectedCalculatedValueTwo = "19";
            string expectedCalculatedValueThree = "28.566370614359172";
            string expectedCalculatedValueFour  = "Error";
            string expectedCalculatedValueFive = "0.087160346581195216992";

            // Act
            string calculatedExpressionOne = CalculatorHelper.Calculate(inputExpressionOne);
            string calculatedExpressionTwo = CalculatorHelper.Calculate(inputExpressionTwo);
            string calculatedExpressionThree = CalculatorHelper.Calculate(inputExpressionThree);
            string calculatedExpressionFour = CalculatorHelper.Calculate(inputExpressionFour);
            string calculatedExpressionFive = CalculatorHelper.Calculate(inputExpressionFive);

            // Assert
            Assert.Equal(expectedCalculatedValueOne, calculatedExpressionOne);
            Assert.Equal(expectedCalculatedValueTwo, calculatedExpressionTwo);
            Assert.Equal(expectedCalculatedValueThree, calculatedExpressionThree);
            Assert.Equal(expectedCalculatedValueFour, calculatedExpressionFour);
            Assert.Equal(expectedCalculatedValueFive, calculatedExpressionFive);

        }
    }
}