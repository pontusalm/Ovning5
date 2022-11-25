using System.ComponentModel.Design;

namespace Ovning5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Console application Garage running!");
            ////Manager.Menu();


            int garagesize = 5;
            Vehicle[] GarageArray = new Vehicle[garagesize];

            GarageArray[0] = new Car("abc123", "Blue", "Petrol");
            GarageArray[1] = new Car("def456", "Red", "Diesel");
            GarageArray[2] = new Car("zxs767", "Green", "Petrol");
            GarageArray[3] = new Car("npe002", "Green", "Electric");
            GarageArray[4] = new Car("dnw122", "Green", "Hybrid");

            foreach (var item in GarageArray)
            {
                Console.WriteLine($"{item.RegNr} {item.Color}");
            }

        }


            class Garage<T> where T : struct
        {
            public T Data { get; set; }
        }

        Garage<Vehicle> garage = new Garage<Vehicle>(); // valid




        //    class DataStore<T> where T : struct
        //{
        //    public T Data { get; set; }
        //}

        //DataStore<int> store = new DataStore<int>(); // valid
        //DataStore<char> store = new DataStore<char>(); // valid
        //DataStore<MyStruct> store = new DataStore<MyStruct>(); // valid





        //Car[] GarageArray = new Car[5];

        //GarageArray[0] = new Car("abc123", "Blue", "Petrol");
        //GarageArray[1] = new Car("def456", "Red", "Diesel");
        //GarageArray[2] = new Car("zxs767", "Green", "Petrol");
        //GarageArray[3] = new Car("npe002", "Green", "Electric");
        //GarageArray[4] = new Car("dnw122", "Green", "Hybrid");

        //foreach (var item in GarageArray)
        //{
        //    Console.WriteLine($"{item.RegNr} {item.Color} {item.Fueltype}");
        //}

       
    }


}
