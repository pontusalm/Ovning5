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

        public virtual string VehicleInfo()
        {
            //return $"Vehicle info: {this.GetType()}, RegNr: {RegNr}, Color: {Color}, ";
            return $"RegNr: {RegNr},\t Color: {Color}, ";
        }
    }

    public class Car : Vehicle
    {
        public string Fueltype { get; set; }

        public Car(string regNr, string color, string fueltype ) : base(regNr, color)
        {
            Fueltype = fueltype;
        }
        public override string VehicleInfo()
        {
            return $"\tCar\t\t {base.VehicleInfo()}\t Fueltype: {Fueltype}";
        }
    }

    public class Bus : Vehicle
    {
        public int NrOfSeats { get; set; }
        public Bus(string regNr, string color, int nrOfSeats) : base(regNr, color)
        {
            NrOfSeats = nrOfSeats;
        }
        public override string VehicleInfo()
        {
            return $"\tBus\t\t {base.VehicleInfo()}\t Nr of seats: {NrOfSeats}";
        }
    }

    public class MC : Vehicle
    {
        public int CylinderVolume { get; set; }
        public MC(string regNr, string color, int cylinderVolume) : base(regNr, color)
        {
            CylinderVolume = cylinderVolume;
        }
        public override string VehicleInfo()
        {
            return $"\tMotorcycle \t {base.VehicleInfo()}\t Cylinder volume: {CylinderVolume}";
        }
    }

  


}
