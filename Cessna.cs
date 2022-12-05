using System;

namespace Garage
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flases by you like a hurrican Zzzzzzoooooommmmm!");
        }
        public override void Turn(string Direction)
        {
            Console.WriteLine($"The {MainColor} Cessna carefully turns {Direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway");
        }
    }
}