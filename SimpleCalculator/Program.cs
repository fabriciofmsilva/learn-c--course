using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int convertedInputToNumber;
            int.TryParse(input, out convertedInputToNumber);

            int number = 90;
            int result = 10 + 10 - 100 + 1000 - number + convertedInputToNumber;
        }
    }
}
