using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you. Rummmble Rummble!");
        }
        public override void Turn(string Direction)
        {
            Console.WriteLine($"The {MainColor} Ram carefully turns {Direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram quickly came to a stop!");
        }
    }
}