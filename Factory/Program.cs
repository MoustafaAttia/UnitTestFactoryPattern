using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle;
            vehicle = VehicleFactory.GetInctanse(VehicleFactory.Vehicles.Car);
            vehicle.SetSpeed(50);
            vehicle.Drive();
            
            vehicle = VehicleFactory.GetInctanse(VehicleFactory.Vehicles.Bus);
            vehicle.SetSpeed(50);
            vehicle.Drive();
        }
    }
}
