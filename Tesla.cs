using System;

namespace Garage
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you MMmmmmmm!");
        }

        public override void Turn(string Direction)
        {
            Console.WriteLine($"The {MainColor} Tesla carefully turns {Direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla quietly comes to a stop");
        }
    }
}