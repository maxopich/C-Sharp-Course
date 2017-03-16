using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_14
{
    class House
    {
        protected float  price;
        protected float area=100;
        protected int numOfRooms=3;
        protected float pricePerMeter=1342;
        public float FullPrice() =>  price = area * pricePerMeter;
        public  void PrintInfo()
        {
            FullPrice();
            Console.WriteLine($"Кiльлiсть кiмнат: {numOfRooms}, цiна: {price}, плoща: {area}");
        }

    }
}
