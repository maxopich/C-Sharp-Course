using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_20
{
   public class Vector:IPrintable
    {
        private float _x;
        private float _y;
        private float _magn;
        public float x
        {
            get { return _x; }
            set {
                _x = value;
                CalcMagnitude();
            }
        }
        public float y
        {
            get { return _y; }
            set {
                _y = value;
                CalcMagnitude();
            }
        }
        public float magnitude
        {
            get { return _magn; }
        }
        public Vector(float pX =0,float pY = 0)
        {
            x = pX;
            y = pY;
        }
        private void CalcMagnitude()
        {
            _magn =(float) Math.Sqrt(x * x + y * y);
        }
        public void Print()
        {
            Console.WriteLine("x={0},y={1} , magnitide = {2}",x,y,magnitude);
        }
        public void TryClone() => new Vector(x, y);
        

        
    }
}
