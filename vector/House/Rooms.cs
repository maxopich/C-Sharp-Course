using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Rooms
    {
        private float mArea;
        public float area
        {
            get { return mArea; }
        }

        public Rooms(float area)
        {
            mArea = area;
        }
    }
}
