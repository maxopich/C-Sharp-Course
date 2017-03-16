using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_14
{
    class Program
    {
        static void Main(string[] args)
        {
            House h = new House();
            h.PrintInfo();
            Console.WriteLine(h.FullPrice());
        }
    }
}
