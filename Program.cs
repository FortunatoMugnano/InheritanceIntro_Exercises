using System;

namespace InheritanceIntro
{

    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine($"The {MainColor} Vroom!!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turn {direction}");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle stops!");
        }

        public virtual void TestDrive(string direction)
        {
            Drive();
            Turn(direction);
            Stop();
            Console.WriteLine();
        }
    }
    public class Zero : Vehicle
    { // Electric motorcycle
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives past... Bruuuumbrummmmm!!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero turns {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Zero stop");
        }

        public void ChargeBattery() { }
    }
    public class Cessna : Vehicle
    { // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna drives past... Zoooooooooom!!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna carefully turn {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Cessna gently rolls to a stop");
        }

        public void RefuelTank() { }
    }
    public class Tesla : Vehicle
    { // Electric car
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine(($"The {MainColor} Tesla drives past... ZZZZzzzzzZZZZZzzz!!"));
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla turns {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The tesla gently stop");
        }
        public void ChargeBattery() { }
    }
    public class Ram : Vehicle
    { // Gas powered truck
        public double FuelCapacity { get; set; }

        public void RefuelTank() { }
        public override void Drive()
        {
            Console.WriteLine(($"The {MainColor} Ram drives past... Vroooom!!"));
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram aggressively turn {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Ram tries to Stop but it crushes!");
        }
        public override string ToString()
        {
            return FuelCapacity.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var zero = new Zero();
            var teslaX = new Tesla();
            var tesla = new Tesla();
            var cessna = new Cessna();
            var ram = new Ram();

            zero.MainColor = "White";
            tesla.MaximumOccupancy = 5;
            tesla.MainColor = "Black";
            tesla.MaximumOccupancy = 4;
            cessna.MainColor = "Red";
            cessna.MaximumOccupancy = 20;
            ram.MainColor = "Blue";
            ram.MaximumOccupancy = 6;

            zero.TestDrive("right");
            tesla.TestDrive("left");
            cessna.TestDrive("up in the air");
            ram.TestDrive("back");
            teslaX.TestDrive("left");

            ram.FuelCapacity = 15;
            Console.WriteLine(ram);

        }
    }
}