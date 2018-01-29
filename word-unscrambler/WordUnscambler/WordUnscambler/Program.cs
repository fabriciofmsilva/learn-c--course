using System;
using System.Collections.Generic;

namespace WordUnscambler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = new int[5];
            //myArray[0] = 7;
            //myArray[1] = 8;
            //myArray[2] = 4;
            //myArray[3] = 5;
            //myArray[4] = 15;
            int[] myArray = { 7, 8, 4, 5, 15 };

            Console.WriteLine(myArray);
            Array.Sort(myArray);
            Console.WriteLine(myArray);
        }
    }
}
