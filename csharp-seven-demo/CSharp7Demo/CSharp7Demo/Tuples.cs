using System;

namespace CSharp7Demo
{
    internal class Tuples
    {
        internal void Run()
        {
            Tuple<string, string, int> oldTuple = getOldTuple();
            Console.WriteLine($"{oldTuple.Item1} {oldTuple.Item2} {oldTuple.Item3}");

            // Unnamed Tuple
            var newUnnamedTtuple = getNewUnnamedTuple();
            Console.WriteLine($"{newUnnamedTtuple.Item1} {newUnnamedTtuple.Item2} {newUnnamedTtuple.Item3}");

            var (FristNameV1, LastNameV1, AgeV1) = getNewUnnamedTuple();
            Console.WriteLine($"{FristNameV1} {LastNameV1} {AgeV1}");

            (var FristNameV2, var LastNameV2, var AgeV2) = getNewUnnamedTuple();
            Console.WriteLine($"{FristNameV2} {LastNameV2} {AgeV2}");

            (string FristNameV3, string LastNameV3, int AgeV3) = getNewUnnamedTuple();
            Console.WriteLine($"{FristNameV3} {LastNameV3} {AgeV3}");

            // Named Tuples
            var (FristNameV4, LastNameV4, AgeV4) = getNewNamedTuple();
            Console.WriteLine($"{FristNameV4} {LastNameV4} {AgeV4}");

            (string FristNameV5, string LastNameV5, int AgeV5) = getNewUnnamedTuple();
            Console.WriteLine($"{FristNameV5} {LastNameV5} {AgeV5}");

            var newNamedTuple = getNewNamedTuple();
            Console.WriteLine($"{newNamedTuple.FirstName} {newNamedTuple.LastName} {newNamedTuple.Age}");
        }

        private (string FirstName, string LastName, int Age) getNewNamedTuple()
        {
            return ("Mark", "Wilson", 30);
        }

        private (string, string, int) getNewUnnamedTuple()
        {
            return ("Mark", "Wilson", 30);
        }

        private Tuple<string, string, int> getOldTuple()
        {
            return Tuple.Create("Mark", "Wilson", 30);
        }
    }
}