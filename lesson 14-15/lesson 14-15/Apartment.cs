using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_14_15
{
    class Apartment
    {
        protected float fullArea;
        protected  const int pricePerMeters=200;
        protected int numOfRooms;
        protected int price;
         public float FullArea
        {
            get { return fullArea; }
            set
            {
                fullArea = value;
            }
        }
        public int NumOfRooms
        {
            get { return numOfRooms; }
            set
            {
               numOfRooms = value;
            }
        }
        public Apartment (float area=0,int rooms=0)
        {
            FullArea = area;
            NumOfRooms = rooms;
            price = pricePerMeters * numOfRooms;
        }
        public void PrintInfo()
        {
            Console.WriteLine("This is base ");
            Console.WriteLine("Numbers of rooms :{0} , full area :{1} ,price :{2}",numOfRooms,fullArea,price);
        }
    }
}
