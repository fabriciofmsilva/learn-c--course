using System;

namespace SudokuSolver
{
    class Car
    {
        private bool _on;

        public void TurnOnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "The car is on!" : "The car is off!");
        }

        public void Drive()
        {
            if (_on)
            {
                Console.WriteLine("Drive car");
            }
            else
            {
                Console.WriteLine("have to start car first!");
            }
        }
    }
}
