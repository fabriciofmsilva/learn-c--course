using System;

namespace CSharp7Demo
{
    class Deconstruction
    {
        public void Run()
        {
            var (myGas, myMileage, myName) = new Car(100, 1000, "Car1");

            Console.WriteLine($"My gas {myGas}");
            Console.WriteLine($"My mileage {myMileage}");
            Console.WriteLine($"My name {myName}");

            var (yourGas, yourMileage, _) = new Car(200, 2000, "Car2");
            Console.WriteLine($"Your gas {yourGas}");
            Console.WriteLine($"Your mileage {yourMileage}");
        }
    }

    class Car
    {
        public int Gas { get; set; }
        public int Mileage { get; set; }
        public string Name { get; set; }

        public Car(int gas, int mileage, string name)
        {
            this.Gas = gas;
            this.Mileage = mileage;
            this.Name = name;
        }

        public void Deconstruct(out int Gas, out int Mileage, out string Name)
        {
            Gas = this.Gas;
            Mileage = this.Mileage;
            Name = this.Name;
        }
    }
}