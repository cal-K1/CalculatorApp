using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorApp.Helpers
{
    public static class CalculatorHelper
    {
        public static string FormatString(string initialString)
        {
            string formattedString = string.Empty;
            try
            {
                formattedString = initialString.Replace("X", "*").Replace("÷", "/").Replace("π", "3.14159265358979");

                // Handle squared expressions
                if (formattedString.Contains("²"))
                {
                    // Extract the base number
                    string baseNumberStr = Regex.Match(formattedString, @"\d+").Value;
                    double baseNumber = double.Parse(baseNumberStr);

                    double result = Math.Pow(baseNumber, 2);

                    formattedString = formattedString.Replace($"{baseNumberStr}²", result.ToString());
                }
            }
            catch (Exception ex)
            {
                formattedString = "Error";
            }
            return formattedString;
        }

        public static string Calculate(string formattedString)
        {
            string completeCalculation = string.Empty;
            try
            {
                completeCalculation = new DataTable().Compute(formattedString, null).ToString();

            }
            catch
            {
                completeCalculation = "Error";
            }
            return completeCalculation;
        }
    }
}
