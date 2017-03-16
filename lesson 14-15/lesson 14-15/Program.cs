
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_14_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartment a1 = new Apartment(100, 3);
            a1.PrintInfo();
            Flat f1= new Flat ( 70, 2, "studio" );
            f1.PrintInfo();
            Villa v1=new Villa(300, 10, 150);
            v1.PrintInfo();
        }
    }
}
