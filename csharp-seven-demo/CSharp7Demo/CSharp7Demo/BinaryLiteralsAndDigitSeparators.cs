using System;

namespace CSharp7Demo
{
    public class BinaryLiteralsAndDigitSeparators
    {
        public void Run()
        {
            byte binaryNumber = 0b111;
            Console.WriteLine(Convert.ToInt16(binaryNumber));

            long veryLongNumber = 100_000_000_000;
            Console.WriteLine(veryLongNumber);
        }
    }
}