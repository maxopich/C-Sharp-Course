using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product[] p = new Product[6];




            for ( int i = 0; i < p.Length; i++)
            {
                Console.WriteLine("Print price , category , name");
                p[i] = new Product(float.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());

            
            }
        }
    }
}
