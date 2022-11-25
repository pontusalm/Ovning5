using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5
{
    public abstract class Vehicle
    {
        public string RegNr { get; set; }
        public string Color { get; set; }
        public Vehicle(string regNr, string color)
        {
            Color = color;
            RegNr = regNr;
        }

        public virtual string Stats()
        {
            return $"Vehicle info: {this.GetType()}, RegNr: {RegNr}, Color: {Color}, ";
        }
    }

    public class Car : Vehicle
    {
        public string Fueltype { get; set; }

        public Car(string regNr, string color, string fueltype ) : base(regNr, color)
        {
            Fueltype = fueltype;
        }
    }

    public class Bus : Vehicle
    {
        public int NrOfSeats { get; set; }
        public Bus(string regNr, string color, int nrOfSeats) : base(regNr, color)
        {
            NrOfSeats = nrOfSeats;
        }
    }

    public class MC : Vehicle
    {
        public int CylinderVolume { get; set; }
        public MC(string regNr, string color, int cylinderVolume) : base(regNr, color)
        {
            CylinderVolume = cylinderVolume;
        }
    }

  


}
