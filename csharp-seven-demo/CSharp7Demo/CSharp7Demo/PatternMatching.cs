using System;

namespace CSharp7Demo
{
    abstract class Person
    {
        public bool IsAngry { get; }

        public Person(bool isAngry) => IsAngry = isAngry;
    }

    class NormalPerson : Person
    {
        public NormalPerson(bool isAngry)
            : base(isAngry)
        {
        }
    }

    class SuperPerson : Person
    {
        public SuperPerson(bool isAngry)
            : base(isAngry)
        {
        }
    }

    class PatternMatching
    {
        public void Run()
        {
            Person normalPerson = new NormalPerson(true);
            Person superPerson = new SuperPerson(true);

            BreakTheWall(normalPerson);
            BreakTheWall(superPerson);

            WhatCanYouBreak(normalPerson);
            WhatCanYouBreak(superPerson);
            WhatCanYouBreak(null);
        }

        private void BreakTheWall(Person person)
        {
            if (person is SuperPerson)
            {
                SuperPerson newPerson1 = person as SuperPerson;
                SuperPerson newPerson2 = (SuperPerson)person;
            }

            if (person is SuperPerson superPerson || person is NormalPerson normalPerson && normalPerson.IsAngry)
            {
                Console.WriteLine("Wall broke!");
            }
            else
            {
                Console.WriteLine("Wall didn't break!");
            }
        }

        private void WhatCanYouBreak(Person person)
        {
            switch (person)
            {
                default:
                    Console.WriteLine("Nothing broke.");
                    break;
                case SuperPerson superPerson when superPerson.IsAngry:
                    Console.WriteLine("Can breck stone wall, titanum wall.");
                    break;
                case SuperPerson superPerson:
                    Console.WriteLine("Can breck stone wall.");
                    break;
                case NormalPerson normalPerson when normalPerson.IsAngry:
                    Console.WriteLine("Can breck stone wall.");
                    break;
                case NormalPerson normalPerson:
                    Console.WriteLine("Cannot break stone wall.");
                    break;
                case null:
                    Console.WriteLine("The wall will stay as it is since nobody will be hitting it.");
                    break;
            }
        }
    }
}