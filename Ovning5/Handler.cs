using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5
{
    public class Handler
    {
        Garage GarageArray = new Garage();

        public void ParkVehicle()
        {
            // Method for parking vehicle

            Console.Clear();
            Console.WriteLine("Parking vehicle");
            Console.ReadLine();
        }

        public void UnparkVehicle()
        {
            Console.Clear();
            Console.WriteLine("Unparking vehicle");
            Console.ReadLine();
        }

        public void ListParkedVehicles()
        {
            Console.Clear();
            Console.WriteLine("\tVehicles currently parked in the garage:");
            GarageArray.DispalyGarageData();

        }

        public void SearchVehicles()
        {
            Console.Clear();
            Console.WriteLine("Search vehicles");
            Console.ReadLine();
        }





    }
   
}
