using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //string newText = "this is some text".Substring(8, 1000);

            //Exception myFirstException = new Exception();

            string input = Console.ReadLine();

            int convertedNumber;
            bool isConvertedSuccessfully = int.TryParse(input, out convertedNumber);

            if (!isConvertedSuccessfully)
            {
                throw new Exception("Conversion was not successful.");
            }
        }
    }
}
