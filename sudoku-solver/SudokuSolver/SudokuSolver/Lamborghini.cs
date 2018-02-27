using System;

namespace SudokuSolver
{
    class Lamborghini : Car
    {
        public override void Drive()
        {
            if (_on)
            {
                Console.WriteLine("Drive Ferrari");
            }
            else
            {
                Console.WriteLine("have to start Ferrari first!");
            }
        }
    }
}
