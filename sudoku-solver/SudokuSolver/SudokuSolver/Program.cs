namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ferrari = new Ferrari();
            Person person = new Person(ferrari);
            person.Drive();

            Car lamborghini = new Lamborghini();
            Person person2 = new Person(lamborghini);
            person.Drive();
        }
    }
}
