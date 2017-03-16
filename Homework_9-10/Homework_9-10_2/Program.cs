using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_10_2
{
    class Program
    {
        public static string A(string str , params int [] a)
        {
            int sum = 0;
            for ( int i= 0; i < a.Length; i++)
            {
                
                sum += a[i];
            }
            if (sum <= 20)
            {
                return "Is'n enough";

            }
            return str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(A("some text",1,4,9));
        }
    }
}
