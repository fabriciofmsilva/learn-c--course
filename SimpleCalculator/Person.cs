using System;

namespace SimpleCalculator
{
    public class Person
    {
        private int _age = 25;

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int newAge)
        {
            _age = newAge;
        }

        static public void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
