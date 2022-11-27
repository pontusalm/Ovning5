using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Ovning5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Console application Garage running!");
            //Manager.Menu();


            int garageSize = 5;
            Vehicle[] GarageArray = new Vehicle[garageSize];

            GarageArray[0] = new Bus("bus123", "Blue", 74);
            GarageArray[1] = new Car("car456", "Red", "Diesel");
            GarageArray[2] = new MC("mcm767", "Green", 250);
            GarageArray[3] = new Car("car002", "Green", "Electric");
            GarageArray[4] = new Car("car122", "Green", "Hybrid");


            foreach (Vehicle item in GarageArray)
            {
                //Console.WriteLine($"{item.RegNr} {item.Color}");
                Console.WriteLine(item.Stats());
            }

        }

        //    class Garage<T> where T : struct
        //{
        //    public T Data { get; set; }
        //}

        //IEnumerable garage1 = new Garage[]
        //{
        //    new Car() {RegNr="abc456",Color= "Red",Fueltype= "Petrol"} };

        //Garage<Vehicle> garage = new Garage<Vehicle>(); // valid




        //    class DataStore<T> where T : struct
        //{
        //    public T Data { get; set; }
        //}

        //DataStore<int> store = new DataStore<int>(); // valid
        //DataStore<char> store = new DataStore<char>(); // valid
        //DataStore<MyStruct> store = new DataStore<MyStruct>(); // valid




    }


}
