using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_18_3
{
    class Vector  
    {
        private int x ;
        private int y;
        private int magn;

        public int X
        {
            get { return x; }
            set { x = value; CalcMagnitude(); }
        }
        public int Y
        {
            get { return y; }
            set { y = value; CalcMagnitude(); }
        }
        public int Magn
        {
            get { return magn; }
            set { }
        }
         private void CalcMagnitude()
        {
            magn = (int)Math.Sqrt(x * x + y * y);
        }
        public void PrintInfo()
        {
            Console.WriteLine($"X={x},\tY={y},\tMagn={magn}");
        }
      
     

    }
}

