using System;
using System.Collections.Generic;

namespace WordUnscambler
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVarFirstList = new List<int>();
            List<int> myFirstList = new List<int>();

            Console.WriteLine(myFirstList.Count);

            myFirstList.Add(10);
            myFirstList.Add(5);
            //myFirstList.Add("text");

            Console.WriteLine(myFirstList.Count);
        }
    }
}
