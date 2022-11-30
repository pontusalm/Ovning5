using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5
{
    public class Handler
    {
        //Garage<Vehicle>GarageArray = new Garage<Vehicle>(10);
        //GarageArray.AddVehicle(new Car("abc123", "Red", "Diesel"));

        public void ParkCar(Garage<Vehicle> GarageArray)
        {
            Console.WriteLine("\tEnter registration number of your car");
            Console.Write("\t"); string regNr = Console.ReadLine();
            Console.WriteLine("\tEnter the color of your car");
            Console.Write("\t"); string color = Console.ReadLine();
            Console.WriteLine("\tEnter the fueltype of your car");
            Console.Write("\t"); string fueltype = Console.ReadLine();

            GarageArray.AddVehicle(new Car(regNr, color, fueltype));

            foreach (Vehicle item in GarageArray)
            {
                if (regNr == item.RegNr)
                {
                    Console.WriteLine(item.VehicleInfo());
                    Console.WriteLine("\tVehicle succerssfully parked in the garage");
                    Console.WriteLine("\n\tPress enter to return to main menu.");
                    Console.Write("\t"); Console.ReadLine();
                    Manager.Menu();
                }
            }
        }

        public void UnparkVehicle(Garage<Vehicle> GarageArray)
        {
            Console.Clear();
            Console.WriteLine("\tUnparking vehicle");
            GarageArray.RemoveVehicle();
            Console.WriteLine("\t Your vehicle is no longer parked in the garage.");
            Console.WriteLine("\n\tPress enter to return to main menu.");
            Console.Write("\t"); Console.ReadLine();
        }

        public void ListParkedVehicles(IEnumerable<Vehicle> GarageArray)
        {
            Console.Clear();
            Console.WriteLine("\tVehicles currently parked in the garage:");
            foreach (Vehicle item in GarageArray)
            {
                Console.WriteLine(item.VehicleInfo());
            }
            Console.WriteLine("\n\tPress enter to return to main menu");
            Console.Write("\t"); Console.ReadLine();
        }

        public void SearchVehicles(Garage<Vehicle> GarageArray)
        {
            SearchVehicles runquery = new SearchVehicles(GarageArray);
            Console.WriteLine("\tEnter Car, Bus or MC");
            string input = Console.ReadLine();

            if (runquery.SearchVehicleType(input.ToLower()) != true)
            {
                this.SearchVehicles(GarageArray);
            }



            Console.Write("\t"); Console.ReadLine();
            //GarageArray.SearchVehicle();

        }





    }
   
}
