using System;

namespace SudokuSolver
{
    class Ferrari : Car
    {
        public void Drive()
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
