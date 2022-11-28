using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5
{
    public class Garage<T> : IEnumerable<T>where T : Vehicle
    {
        public static int garageSize = 5;
        //Vehicle[] GarageArray = new Vehicle[garageSize];
        private int capacity;
        private int count;
        private T[] Vehicles;

        public Garage(int capacity)
        {
        this.capacity = capacity;
            Vehicles = new T[capacity];
            count = 0;
            

                
        }
        //public Garage()
        //{
        //    GarageArray[0] = new Bus("bus123", "Blue", 74);
        //    GarageArray[1] = new Car("abc123", "Red", "Diesel");
        //    GarageArray[2] = new MC("mcm767", "Green", 250);
        //    GarageArray[3] = new Car("car002", "Green", "Electric");
        //    GarageArray[4] = new Car("car122", "Green", "Hybrid");
        //}

        public int Count<U>() where U : T
        {
            int n = 0;


            foreach (T item in Vehicles)
	        {
                if (item is U)
                {
                    n++;   
                }
	        }
            return n;
        }


        public void AddVehicle(T vehicle)
        {
            if (count < capacity)
            {
                Vehicles[count++] = vehicle;
            }
            else
            {
                Console.WriteLine("Garage is full");
            } 
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("\tEnter regnr for your vehicle to unpark");
            Console.Write("\t");
            string regnrSearch = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (Vehicles[i].RegNr == regnrSearch)
                {
                    Vehicles[i] = null;
                    Array.Copy(Vehicles, i + 1, Vehicles, i, count - i - 1);
                    count--;    
                    return;
                }
                else Console.WriteLine("Your vehicle is not parked in the garage.");
            }
                
            Console.WriteLine($"\tVehicle with regnr is {regnrSearch} is not parked in the garage.");
            Console.ReadLine();
        }


        public void DispalyGarageData()
        {
            //foreach (Vehicle item in GarageArray)
            //{
            //    Console.WriteLine(item.VehicleInfo());
            //}
            //Console.ReadLine();
        }

        public void SearchVehicle() => Console.WriteLine("\tEnter regnr for your vehicle");//Console.Write("\t");//string regnrSearch = Console.ReadLine();//foreach (Vehicle item in GarageArray)//{//    if (regnrSearch == item.RegNr)//    { //        Console.WriteLine(item.VehicleInfo());//        Console.WriteLine("\n\tPress any key to return to main menu.");//        Console.ReadLine();//        Manager.Menu();//    }//}//Console.WriteLine($"\tVehicle with regnr is {regnrSearch} is not parked in the garage.");//SearchVehicle();



       
        public IEnumerator<T>GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return Vehicles [i];    
            }

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();

    
//throw new NotImplementedException();

        //IEnumerator<T> IEnumerable<T>GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
