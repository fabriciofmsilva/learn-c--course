using System;
using System.Collections.Generic;

namespace WordUnscambler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 6, 9, 10 };
            List<int> list = new List<int>() { 1, 5, 6, 9, 10 };

            foreach (var element in array)
            {
                Console.WriteLine(element);
            }

            // not make sanse for this case, foreach is more clean
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // not make sense for this case
            int index = 0;
            while (index < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
            }

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
