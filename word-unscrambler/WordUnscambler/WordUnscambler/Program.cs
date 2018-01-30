using System;

namespace WordUnscambler
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            ChangeNumber(a);
            Console.WriteLine(a);

            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Smith";

            ChangeName(person);
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }

        static void ChangeNumber(int a)
        {
            a = 90;
        }

        static void ChangeName(Person personToChange)
        {
            personToChange.FirstName = "Jane";
            personToChange.LastName = "Doe";
        }
    }
}
