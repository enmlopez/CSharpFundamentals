using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTest
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdooble";
            cookie.HasNuts = false;

            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";
            anotherCookie.HasNuts = true;

            //Constructors
            Cookie snickerDoodle = new Cookie("Snickerdoodle", false, 11.5);
            Cookie newCookie = new Cookie("Peanut Butter", true, 150);
        }

        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            //Object Initialization Syntax
            Vehicle newCar = new Vehicle
            {
                TypeOfVehicle = VehicleType.Car,
                Make = "Honda",
                Model = "Civic",
            };

        }
    }
}
