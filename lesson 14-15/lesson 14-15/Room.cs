using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_14_15
{
    class Room:Apartment
    {

        protected int rooms;
        protected string type;
        protected float areaOfRoom;
        Random x = new Random();
        Random y= new Random();


        private float AreaOFRooms(int rooms)
        {
            this.rooms = rooms;
            switch (rooms)
            {
                case 2:
            }
        }

        public Room(float area , int rooms):base(area, rooms)
        {

        }

    }
}
