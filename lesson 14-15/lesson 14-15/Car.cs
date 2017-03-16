
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_14_15
{
    class Car
    {
        private int  numOfWheels;
        private string model;

        public Car(string m = "Unknown", int num = 4)
        {
            model = m;
            numOfWheels = num;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Car model : {0} , wheels {1}",model ,numOfWheels);
        }

    }
}
