using Microsoft.VisualBasic.FileIO;
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
            //return $"Vehicle info: {this.GetType()}, RegNr: {RegNr}, Color: {Color}, ";
            return $"Vehicle info: RegNr: {RegNr}, Color: {Color}, ";
        }
    }

    public class Car : Vehicle
    {
        public string Fueltype { get; set; }

        public Car(string regNr, string color, string fueltype ) : base(regNr, color)
        {
            Fueltype = fueltype;
        }
        public override string Stats()
        {
            return base.Stats() + $"Fueltype: {Fueltype}";
        }
    }

    public class Bus : Vehicle
    {
        public int NrOfSeats { get; set; }
        public Bus(string regNr, string color, int nrOfSeats) : base(regNr, color)
        {
            NrOfSeats = nrOfSeats;
        }
        public override string Stats()
        {
            return base.Stats() + $"Nr of seats: {NrOfSeats}";
        }
    }

    public class MC : Vehicle
    {
        public int CylinderVolume { get; set; }
        public MC(string regNr, string color, int cylinderVolume) : base(regNr, color)
        {
            CylinderVolume = cylinderVolume;
        }
        public override string Stats()
        {
            return base.Stats() + $"Cylinder volume: {CylinderVolume}";
        }
    }

  


}
