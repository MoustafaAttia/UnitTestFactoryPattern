using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factory;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestSpeed()
        {
            // Arrange
            IVehicle car,bus;
            int actualCarSpeed, actualBusSpeed;
            car = VehicleFactory.GetInctanse(VehicleFactory.Vehicles.Car);
            car.SetSpeed(100);
            int expectedCarSpeed = 300;
            bus = VehicleFactory.GetInctanse(VehicleFactory.Vehicles.Bus);
            bus.SetSpeed(100);
            int expectedBusSpeed = 300;

            // Act
            actualCarSpeed = car.GetSpeed();
            actualBusSpeed = bus.GetSpeed();

            // Assert
            Assert.AreEqual(actualCarSpeed, expectedCarSpeed);
            Assert.AreEqual(actualBusSpeed, expectedBusSpeed);
        }
    }
}
