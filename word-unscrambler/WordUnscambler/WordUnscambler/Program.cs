using System;
using System.Collections.Generic;

namespace WordUnscambler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myFirstArray = new int[10];

            //myFirstArray[1000] = 5;
            //myFirstArray[10] = 5;
            myFirstArray[9] = 5;

            var mySecondList = new List<int>();
            mySecondList.Add(5);

            Console.WriteLine(mySecondList[0]);
            //Console.WriteLine(mySecondList[1]);
        }
    }
}
