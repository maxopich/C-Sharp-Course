using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17_18_3
{
    class Program
    {
        static void Main(string[] args)
             
        {
            int temp = int.MaxValue; 
            Vector[] v = new Vector[4];
            for(int i = 0; i < v.Length; i++)
            {
                v[i] = new Vector() { X = int.Parse(Console.ReadLine()), Y = int.Parse(Console.ReadLine()) };
                v[i].PrintInfo();
            }
            Console.WriteLine("PUM PUM \n\n");
            for (int i = 0; i < v.Length; i++)
            {
                if(v[i].Magn>5)
                v[i].PrintInfo();
            }
        }
    }
}
