using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5
{
    public class Handler
    {
        //Garage<Vehicle>GarageArray = new Garage<Vehicle>(10);
        //GarageArray.AddVehicle(new Car("abc123", "Red", "Diesel"));

        public void ParkVehicle(Garage<Vehicle> garage)
        {
            // Method for parking vehicle
            garage.AddVehicle(new Car("def999", "Red", "Diesel"));
            Console.WriteLine("garage" + garage);
            foreach (Vehicle item in garage)
            {
                Console.WriteLine(item.RegNr);
            }
          
            Console.Clear();
            Console.WriteLine("Parking vehicle in the garage");
            Console.ReadLine();
        }

        public void UnparkVehicle()
        {
            Console.Clear();
            Console.WriteLine("Unparking vehicle");
            Console.ReadLine();
        }

        public void ListParkedVehicles(IEnumerable<Vehicle> GarageArray)
        {
            Console.Clear();
            Console.WriteLine("\tVehicles currently parked in the garage:");
            foreach (Vehicle item in GarageArray)
            {
                Console.WriteLine(item.VehicleInfo());
            }
            Console.WriteLine("\n\tPress any key to return to main menu");
            Console.ReadLine();
        }

        public void SearchVehicles(IEnumerable<Vehicle> GarageArray)
        {
            Console.WriteLine("\tEnter regnr for your vehicle");
            Console.Write("\t");
            string? v = Console.ReadLine();
            string? regnrSearch = v;
            foreach (Vehicle item in GarageArray)
            {
                if (regnrSearch == item.RegNr)
                {
                    Console.WriteLine(item.VehicleInfo());
                    Console.WriteLine("\n\tPress any key to return to main menu.");
                    Console.ReadLine();
                    Manager.Menu();
                }
            }
            Console.WriteLine($"\tVehicle with regnr is {regnrSearch} is not parked in the garage.");
            Console.WriteLine("\n\tPress any key to return to main menu.");
            Console.ReadLine();
            
        }





    }
   
}
