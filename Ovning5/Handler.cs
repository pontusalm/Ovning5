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

        public void ListParkedVehicles()
        {
            //Console.Clear();
            //Console.WriteLine("\tVehicles currently parked in the garage:");
            //GarageArray.DispalyGarageData();

        }

        public void SearchVehicles()
        {
            //Console.Clear();
            //Console.WriteLine("\tSearch vehicles");
            //GarageArray.SearchVehicle();
            //Console.ReadLine();
        }





    }
   
}
