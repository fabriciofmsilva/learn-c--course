using System;
using System.Text;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Person person = new Person(car);
            person.Drive();
        }
    }
}
