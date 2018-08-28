﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Car : IVehicle
    {
        private int speed = 0;
        
        public void Drive()
        {
            Console.WriteLine("This is CAR driving, with speed {0} !", speed);
        }


        public void SetSpeed(int _speed)
        {
            if (_speed <= 0)
                throw new ArgumentOutOfRangeException("Speed cannot be zero of negative !");
            speed = 3 * _speed;
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}
