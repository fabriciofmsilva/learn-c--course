using System;
using System.Collections.Generic;

namespace WordUnscambler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This is line 1.");
            //Console.WriteLine("This is line 2.");
            //Console.WriteLine("This is line 3.");
            //Console.WriteLine("This is line 4.");
            //Console.WriteLine("This is line 5.");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("This is line {0}", i);
            }

            //Console.WriteLine("This is line 5.");
            //Console.WriteLine("This is line 4.");
            //Console.WriteLine("This is line 3.");
            //Console.WriteLine("This is line 2.");
            //Console.WriteLine("This is line 1.");

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine("This is line {0}", i);
            }
        }
    }
}
