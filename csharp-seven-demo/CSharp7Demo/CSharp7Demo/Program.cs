using System;

namespace CSharp7Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte binaryNumber = 0b111;
            Console.WriteLine(Convert.ToInt16(binaryNumber));

            long veryLongNumber = 100_000_000_000;
            Console.WriteLine(veryLongNumber);
        }
    }
}
