using System;

namespace InheritanceIntro
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vroom!");
        }
    }

    public class Zero : Vehicle
    { // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine("Zooooooom!!");
        }
    }

    public class Cessna : Vehicle
    { // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public void RefuelTank() { }
    }
    public class Tesla : Vehicle
    { // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine("zzzzZZZZZZzzzzzz");
        }
    }
    public class Ram : Vehicle
    { // Gas powered truck
        public double FuelCapacity { get; set; }

        public void RefuelTank() { }

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
            var tesla = new Tesla();
            var cessna = new Cessna();
            var ram = new Ram();

            zero.MainColor = "White";
            tesla.MaximumOccupancy = 5;

            zero.Drive();
            tesla.Drive();
            cessna.Drive();
            ram.Drive();
            ram.FuelCapacity = 12;
            Console.WriteLine(ram);
        }
    }
}