using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IVehicle
    {
        // test
        void Drive();
        void SetSpeed(int _speed);
        int GetSpeed();
    }
}
