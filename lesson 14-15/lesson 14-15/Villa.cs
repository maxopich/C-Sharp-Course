using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_14_15
{
    class Villa:Apartment
    {
        protected float externalArea;
        public float ExternalArea 
        {
            get { return externalArea; }
            set
            {
                externalArea = value;
            }
        }
        public Villa(float area, int rooms, float externalArea):base ( area , rooms)
        {
            ExternalArea = externalArea;
            FullArea = area+externalArea;
            NumOfRooms = rooms;
           
            price = pricePerMeters * numOfRooms;
        }
        public void PrintInfo()
        {
            Console.WriteLine("This is villa ");
            Console.WriteLine("Numbers of rooms :{0} , full area :{1} ,externalArea :{2}, price :{3}", numOfRooms, fullArea, externalArea ,price );
        }
    }
}
