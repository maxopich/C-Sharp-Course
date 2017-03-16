using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_14_15
{
    class Flat:Apartment
    {
        private string type;
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
            }
        }

        public Flat (float area , int rooms , string type ):base ( area ,  rooms)
        {
            FullArea = area;
            NumOfRooms = rooms;
            this.type = type;
            price = pricePerMeters * numOfRooms;
        }
        public void PrintInfo()
        {
            Console.WriteLine("This is flat ");
            Console.WriteLine("Numbers of rooms :{0} , full area :{1} ,price :{2}, type :{3}", numOfRooms, fullArea, price,type); 
        }
    }
}
