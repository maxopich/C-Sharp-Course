using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int sum = 0;
            int first=0;
            int second=0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
               
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    first = i;
                    break;

                }
            }
            for (int i = first + 1; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    second = i;
                    break;

                }
            }
            for(int i = first + 1; i < second; i++)
            {
                sum += a[i];
            }

                Console.WriteLine(first+" "+second);
            Console.WriteLine("sum="+sum);
        }
    }
}
