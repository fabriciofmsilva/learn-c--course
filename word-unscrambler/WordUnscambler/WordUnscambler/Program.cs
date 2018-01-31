using System;

namespace WordUnscambler
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Smith";

            ChangeName(person);
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }

        static void ChangeName(Person personToChange)
        {
            personToChange.FirstName = "Jane";
            personToChange.LastName = "Doe";
        }
    }
}
