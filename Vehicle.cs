using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string Direction)
        {
            Console.WriteLine($"The Vehicle carefully turns {Direction}");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The Vehicle gently rolls to a stop!");
        }
    }
}