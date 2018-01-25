using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            if (username.Equals("Avetis") && password.Equals("abc123"))
            {
                Console.WriteLine("Hello Admin!");
            }
            else if (username.Equals("Joe") && password.Equals("abc1234"))
            {
                Console.WriteLine("Hello Moderator!");
            }
            else
            {
                Console.WriteLine("Hello Guest!");
            }

            switch (username)
            {
                case "Avetis":
                    Console.WriteLine("Hello Admin!");
                    break;
                case "Joe":
                    Console.WriteLine("Hello Moderator!");
                    break;
                default:
                    Console.WriteLine("Hello Guest!");
                    break;
            }
        }
    }
}
