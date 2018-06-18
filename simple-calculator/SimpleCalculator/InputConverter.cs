using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            return double.TryParse(argTextInput, out double convertedNumber)
                ? convertedNumber
                : throw new ArgumentException("Expected a numeric value.");
        }
    }
}