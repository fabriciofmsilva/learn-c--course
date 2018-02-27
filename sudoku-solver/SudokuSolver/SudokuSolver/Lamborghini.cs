namespace SudokuSolver
{
    class Lamborghini : ICar
    {
        private bool _on;

        public void TurnOnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "The Ferrari is on!" : "The Ferrari is off!");
        }

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
