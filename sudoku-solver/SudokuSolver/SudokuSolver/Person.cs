namespace SudokuSolver
{
    class Person
    {
        private ICar _car;

        public Person(ICar car)
        {
            _car = car;
        }

        public void Drive()
        {
            _car.TurnOnOff();
            _car.Drive();
        }
    }
}
