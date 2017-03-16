using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_10_3
{
    class Program
    {
        public static void Mas(ref int[,] mas ,int rozmir)
        {
            int counter = 0;
            for (int i = 0; i < rozmir; i++)
            {
                for (int j = 0; j < rozmir; j++)
                {

                    mas[i, j] = ++counter;
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int rozmir = int.Parse(Console.ReadLine());
            int[,] mas = new int[rozmir,rozmir];
            Mas (ref mas, rozmir);
          
        }
    }
}
