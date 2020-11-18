using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookie
    {
        public string Name { get; set; }
        public bool HasNuts { get; set; }
        public double GramsOfFlour { get; set; }


        public Cookie()
        {

        }

        public Cookie(string name, bool hasNuts, double gramsOfFlour)
        {
            Name = name;
            HasNuts = hasNuts;
            GramsOfFlour = gramsOfFlour;
        }
    }


    //enumeration - costumizing a type (VehicleType) and giving it certain values
    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat}
    public class Vehicle
    { 
       //prop - shortcut
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage  { get; set; }
        public string Color { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle()
        {

        }
    }

    public class Order
    {
        public String CustomerName { get; set; }
        public Cookie OrderedProduct { get; set; }
        public decimal OrderCost { get; set; }
    }

}
