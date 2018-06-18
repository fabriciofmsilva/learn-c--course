using System;

namespace CSharp7Demo
{
    class Program
    {
        private int _score = 100;
        public int MyScore {
            get => _score;
            set => _score = value > 0 ? value : throw new Exception("Cannot have a score of 0 or below");
        }

        static void Main(string[] args)
        {
            byte binaryNumber = 0b111;
            Console.WriteLine(Convert.ToInt16(binaryNumber));

            long veryLongNumber = 100_000_000_000;
            Console.WriteLine(veryLongNumber);
        }
    }
}
