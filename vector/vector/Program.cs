using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector
{
    class Vector
    {
        private float x;
        private float y;
        private float mang;

        public float X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                CalcMang();
            }
        }
        public Vector(float x, float y)
        {
            this.x = x;
            this.y = y;
            CalcMang();
            
        }
        private void CalcMang()
        {
            mang = (float)Math.Sqrt(x * x + y * y);
        }
        public void SetX(float x)
        {
            this.x = x;
            CalcMang();
        }
        public void SetY(float y)
        {
            this.y = y;
            CalcMang();
        }
        public void PrintInfo()
        {
            Console.WriteLine("X;" + x + "\nY:" + y + "\nMag:" + mang);
        }
        public float GetX() => x;
        public float GetY() => y;
        public float GetMagn() => mang;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(3, 4);
           
            v1.X = 150;
          v1.
        
        
            
        }
    }
}
