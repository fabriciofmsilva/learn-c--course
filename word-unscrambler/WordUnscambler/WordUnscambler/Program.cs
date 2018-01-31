using System;

namespace WordUnscambler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = null;
            Person person = new Person("John", "Smith");

            Person newPerson = person ?? new Person("Default", "Person");

            Console.WriteLine(newPerson.FirstName);
        }
    }
}
