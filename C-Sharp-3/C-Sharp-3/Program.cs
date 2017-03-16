using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            //int[][] ar3 = new int [3][];
            //for(int i =0; i < ar3.Length; i++)
            //{
            //    ar3[i] = new int[i+1];

            //}
            //for( int i = 0; i < ar3.Length; i++)
            //{
            //    for(int j =0; j< ar3[i].Length; j++)
            //    {
            //        ar3[i][j] = x.Next(1, 10);
            //        Console.Write(ar3[i][j]+" ");

            //    }
            //    Console.WriteLine();
            //}
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = x.Next(1, 1000);
                if (a[i] % 2 != 0)
                {
                    a[i] -= 1;
                }
                if (a[i] >= 100)
                {
                    a[i] = 99;
                }
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
            int[] b = new int[10];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = x.Next(1, 1000);
                Console.Write(b[i] + "\t");
            }
            int[] c = new int[10];
            int max = 0;
            int min= int.MaxValue;
            double ser = 0;
            Console.WriteLine();
            for (int i = 0; i < b.Length; i++)
            {
                c[i] = a[i] + b[i];

                Console.Write(c[i]+"\t");
               
                if (c[i] > max)
                {
                    max = c[i];
                }

                if (c[i] < min)
                {
                    min = c[i];
                }
                ser += c[i] / c.Length;
            }
            for (int i = 0; i < b.Length; i++)
            {
               

               
                
                
                if (c[i] > max)
                {
                    max = c[i];
                }
                if (c[i] < min)
                {
                    min = c[i];
                }
                ser += c[i] / c.Length;
            }
            Console.WriteLine(ser);
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}
