using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5
{
    public class Garage : IEnumerable<Vehicle>
    {
        public static int garageSize = 5;
        Vehicle[] GarageArray = new Vehicle[garageSize];
        public Garage()
        {
            GarageArray[0] = new Bus("bus123", "Blue", 74);
            GarageArray[1] = new Car("abc123", "Red", "Diesel");
            GarageArray[2] = new MC("mcm767", "Green", 250);
            GarageArray[3] = new Car("car002", "Green", "Electric");
            GarageArray[4] = new Car("car122", "Green", "Hybrid");
        }

        public void DispalyGarageData()
        {
            foreach (Vehicle item in GarageArray)
            {
                Console.WriteLine(item.VehicleInfo());
            }
            Console.ReadLine();
        }

        public void SearchVehicle()
        {
            Console.WriteLine("\tEnter regnr for your vehicle");
            Console.Write("\t"); string regnrSearch = Console.ReadLine();
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
            SearchVehicle();
        }



        IEnumerator<Vehicle> IEnumerable<Vehicle>.GetEnumerator()
        {
            yield return (Vehicle)GarageArray.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
