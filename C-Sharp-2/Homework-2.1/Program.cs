using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine() ;
            int k = x.Length - 1;
            int counter = 0;
            for (int i = 0; i < x.Length; i++)
            {                
                    if (x[i] == x[k]) counter++;
                                                 
                    k--;

                    if (k < 0) break;
                                                  
            }
            if (counter == x.Length)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO.");
            }
        }
    }
}
