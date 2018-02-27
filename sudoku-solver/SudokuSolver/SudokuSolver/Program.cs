using System;
using System.Text;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferrari ferrari = new Ferrari();
            Person person = new Person(ferrari);
            person.Drive();

            Lamborghini lamborghini = new Lamborghini();
            Person person2 = new Person(lamborghini);
            person.Drive();
        }
    }
}
