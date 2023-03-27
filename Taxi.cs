﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp
{
    class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty);
            Console.WriteLine("Number of Passenger: {0}", NumPassenger);
            
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
 
            Console.WriteLine("================================================");
        }

        public void DropOffPassenger()
        {

            Console.WriteLine("{0} telah selesai mengantar penumpang", DriverName);
            Console.WriteLine("================================================");
        }
    }
}