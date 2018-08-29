using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factory;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestClass]
        public class UnitTest
        {
            [TestMethod]
            public void TestBusSpeed()
            {
                // Arrange
                IVehicle bus;
                int actualBusSpeed;
                bus = VehicleFactory.GetInctanse(VehicleFactory.Vehicles.Bus);
                bus.SetSpeed(100);
                int expectedBusSpeed = 200;

                // Act
                actualBusSpeed = bus.GetSpeed();

                // Assert
                Assert.AreEqual(actualBusSpeed, expectedBusSpeed);
            }

            [TestMethod]
            public void TestCarSpeed()
            {
                // Arrange
                IVehicle car;
                int actualCarSpeed;
                car = VehicleFactory.GetInctanse(VehicleFactory.Vehicles.Car);
                car.SetSpeed(100);
                int expectedCarSpeed = 300;

                // Act
                actualCarSpeed = car.GetSpeed();

                // Assert
                Assert.AreEqual(actualCarSpeed, expectedCarSpeed);
            }

            [TestMethod]
            public void TestBusNegativeSpeed()
            {
                try
                {
                    IVehicle bus;
                    bus = VehicleFactory.GetInctanse(VehicleFactory.Vehicles.Bus);
                    bus.SetSpeed(-50);
                    Assert.Fail();
                }
                catch (Exception ex)
                {
                    Assert.IsTrue(ex is ArgumentOutOfRangeException);
                }
            }

            [TestMethod]
            public void TestCarNegativeSpeed()
            {
                try
                {
                    IVehicle car;
                    car = VehicleFactory.GetInctanse(VehicleFactory.Vehicles.Car);
                    car.SetSpeed(-50);
                    Assert.Fail();
                }
                catch (Exception ex)
                {
                    Assert.IsTrue(ex is ArgumentOutOfRangeException);
                }
            }
        }
    }
}
