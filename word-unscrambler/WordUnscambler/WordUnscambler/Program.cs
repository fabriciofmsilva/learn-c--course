using System;
using System.IO;

namespace WordUnscambler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "This is the first line", "This is the second line", "This is the third line" };
            File.WriteAllLines("MyFirstFile.txt", lines);

            string[] fileContents = File.ReadAllLines("MyFirstFile.txt");

            foreach(string line in File.ReadLines("MyFirstFile.txt"))
            {
                Console.WriteLine(line);
            }
        }
    }
}
