using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    abstract class Car
    {
        protected bool _on;

        public void TurnOnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "The car is on!" : "The car is off!");
        }

        public abstract void Drive();
    }
}
