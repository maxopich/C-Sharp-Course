using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_10
{
    class Program
    {

        public static int Mas(int b , int [] a )
        {

            Random x = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    return i;
                }
            }
            return 1;
        }
        static void Main(string[] args)
        {

            Random x = new Random();
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = x.Next(1, 10);
                Console.Write(a[i]+" ");
               
            }
            Console.WriteLine();
            Console.WriteLine(Mas(5,a));  
        }
    }
}
