using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static private int pricePerMeter = 200;
        //private int numOfRooms;
        //private int area;
        //private int numOfBathrooms;
        private float price;
        private float mPrice = 0;
        private float area;
        private float mArea=0;
        //private Room[] rooms;

        public float Area
        {
            get { return mArea; }

            set { mArea = value; mPrice = pricePerMeter * mArea; }
        }
        public float Price
        {
            get { return price; }
        }

        public House(float area)

        {
            //this.area = area;
        }
        public void Print()
        {
            Console.WriteLine(price);
           for(int i =0; i < roomCount; i++)
            {
                Console.WriteLine("Roon #{0} with area {1}",i+1,rooms[i].area);
            }
        }
        private Rooms[] rooms = new Rooms[10];
        private int roomCount;
        public void AddRoom(Rooms room)
        {
            rooms[roomCount] = room;
            roomCount++;
            this.area += rooms.area;

        }
        public void AddRoom(float area)
        {
            rooms[roomCount] = new Rooms(area);
            roomCount++;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House(10);
            h1.AddRoom(10);
            h1.Print();
        }
    }
}
