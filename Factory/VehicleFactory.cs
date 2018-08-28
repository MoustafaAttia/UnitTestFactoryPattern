using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class VehicleFactory
    {
        public enum Vehicles
        {
            Car,
            Bus
        }
        static public IVehicle GetInctanse(Vehicles vehicle)
        {
            switch (vehicle)
            {
                case Vehicles.Car:
                    return new Car();

                case Vehicles.Bus:
                    return new Bus();

                default: return null;
            }
            
        }
    }
}
