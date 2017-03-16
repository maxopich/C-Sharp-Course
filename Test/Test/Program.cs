using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static int[] Cal(int n)
        {
            int[] a = new int[n];
            
                for(int i = 0; i < n; i++)
                {
                    a[i] = i;                               
                }              
            return a;
        }
        static void Vuv(int []a )
        {
            for(int i =0; i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Vuv(Cal(n));
          

    }
    }
}
