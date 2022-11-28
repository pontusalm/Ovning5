using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5
{
    internal  class Manager
    {
        public static void Menu()
        {

            Garage<Vehicle> GarageArray = new Garage<Vehicle>(10);
            GarageArray.AddVehicle(new Car("abc123", "Red", "Diesel"));
            GarageArray.AddVehicle(new Bus("bus123", "Blue", 74));
            GarageArray.AddVehicle(new MC("mcm767", "Green", 250));
            GarageArray.AddVehicle(new Car("car002", "Green", "Electric"));
            GarageArray.AddVehicle(new Car("car122", "Green", "Hybrid"));


            while (true)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("\tPlease navigate through the menu by inputting the number \n\t(1, 2, 3 ,4, 0) of your choice"
                    + "\n\t1.\t Park vehicle"
                    + "\n\t2.\t Unpark vehicle"
                    + "\n\t3.\t List parked vehicles"
                    + "\n\t4.\t Search vehicles"
                    + "\n\t0.\t Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.

                Handler handler = new Handler();
                try
                {
                    Console.Write("\t"); input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("\t Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        handler.ParkVehicle(GarageArray);
                        
                        break;
                    case '2':
                        handler.UnparkVehicle();

                        break;
                    case '3':
                        handler.ListParkedVehicles(GarageArray);

                        break;
                    case '4':
                        handler.SearchVehicles(GarageArray);
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

      
        

    }
}
