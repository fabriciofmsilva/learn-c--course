using System;

namespace SimpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("SSN", "Data", "More Data");
            Console.WriteLine(person.HasProperDocuments);
        }
    }
}
