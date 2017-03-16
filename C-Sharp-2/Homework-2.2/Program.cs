using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float y = 0.0f;
            Random x = new Random();
            int[,] a = new int[5, 5];           
            for (int i = 0; i <5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = x.Next(1, 10);
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] b = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    b[i, j] = x.Next(1, 10);
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for(int i = 0; i < 5; i++)
            {
                for(int j =0; j < 5; j++)
                {
                    if (a[i, j] == b[i, j])
                    {
                        y += 1;
                    }
                }
            }
            float w = (y / 25) * 100;
            Console.WriteLine(w+"%");
        }
    }
}
