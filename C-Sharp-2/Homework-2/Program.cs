using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            int[,] a = new int[5, 5];
            int sum1=0;
            int sum2 = 0;
            
            for(int i = 0; i <5; i++)
            {
                for (int j = 0; j <5; j++)
                {
                    a[i, j] = x.Next(1,10);
                    Console.Write(a[i, j]+"\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <5; i++)
            {
                for (int j = 0; j <5; j++)
                {
                    if (i ==j)
                    {
                        sum1 += a[i, j];
                     }
                    else if (i + j == 5)
                    {
                        sum2 += a[i, j];
                    }
                }
            }
            Console.WriteLine(sum1+" "+sum2);
        }
    }
}
