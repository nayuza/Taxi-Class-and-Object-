using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat object taxi
            Taxi taxi = new Taxi();

            //seting nilai properties
            taxi.DriverName = "Rifqi";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();

        }
    }
}