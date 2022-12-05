using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you Weeee!");
        }

        public override void Turn(string Direction)
        {
            Console.WriteLine($"The {MainColor} Zero quickly turns {Direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero quickly comes to a stop");
        }
    }
}