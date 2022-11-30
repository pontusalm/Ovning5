using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5
{
    internal class SearchVehicles
    {
        Garage<Vehicle> GarageArray;
        public SearchVehicles(Garage<Vehicle> GarageArray)
        {
            this.GarageArray = GarageArray;
        }

        public Boolean SearchVehicleType(string VehicleTypeStr)
        {
            Type VehicleType = null;
            if (VehicleTypeStr == "car")
            {
                VehicleType = typeof(Car);  
            }
            else if (VehicleTypeStr == "bus")
            {
                VehicleType = typeof(Bus);
            }
            else if (VehicleTypeStr == "mc")
            {
                VehicleType = typeof(MC);
            }
            else
            {
                Console.WriteLine("Enter a valid type of vehicle");
                
                return false;
            }
            
            
            foreach (Vehicle item in this.GarageArray)
            {
                if (item.GetType() == VehicleType)
                {
                    Console.WriteLine(item.VehicleInfo());
                }
            }
            return true;





        }
    }
}
