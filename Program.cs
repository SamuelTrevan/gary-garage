using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram truck = new Ram();

            fxs.BatteryKWh = 100.00;
            fxs.MainColor = "Blue";
            fxs.MaximumOccupancy = 4;

            modelS.BatteryKWh = 150.00;
            modelS.MainColor = "Black";
            modelS.MaximumOccupancy = 5;

            mx410.FuelCapacity = 500.00;
            mx410.MainColor = "Red";
            mx410.MaximumOccupancy = 4;

            truck.FuelCapacity = 35.00;
            truck.MainColor = "Silver";
            truck.MaximumOccupancy = 6;


            fxs.Drive();
            fxs.Turn("Left");
            fxs.Stop();
            Console.WriteLine("-------------------------");

            modelS.Drive();
            modelS.Turn("Right");
            modelS.Stop();
            Console.WriteLine("-------------------------");

            mx410.Drive();
            mx410.Turn("Left");
            mx410.Stop();
            Console.WriteLine("-------------------------");

            truck.Drive();
            truck.Turn("Right");
            truck.Stop();
        }
    }
}