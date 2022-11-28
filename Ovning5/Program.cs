using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Ovning5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console application Garage running!");

            //Garage<Vehicle> GarageArray = new Garage<Vehicle>(10);
            //GarageArray.AddVehicle(new Car("abc123", "Red", "Diesel"));
            //GarageArray.AddVehicle(new Bus("bus123", "Blue", 74));
            //GarageArray.AddVehicle(new MC("mcm767", "Green", 250));
            //GarageArray.AddVehicle(new Car("car002", "Green", "Electric"));
            //GarageArray.AddVehicle(new Car("car122", "Green", "Hybrid"));

            Manager.Menu();
        }

    }
}
