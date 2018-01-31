using System;

namespace WordUnscambler
{
    class Program
    {
        //public const string someText;
        public const string someText = "This is text";
        //public const person person = new Person("A", "B");

        //public static readonly string someOtherText;
        public static readonly string someOtherText = "This is some other text";
        //public static readonly Person person = new Person("A", "B");

        static void Main(string[] args)
        {
            //Program.someText;
            //Program program = new Program();
            //program.someOtherText;

            Console.WriteLine(someText);
            Console.WriteLine(someOtherText);
        }
    }
}
