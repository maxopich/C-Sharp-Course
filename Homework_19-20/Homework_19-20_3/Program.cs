using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19_20_3
{
    class Program
    {
        public static void Check(string line)
        {
            int i;
            Stack<char> num = new Stack<char>();
            for (i = 0; i < line.Length / 2; i++)
            {
                num.Push(line[i]);
            }
          
            if (line.Length % 2 != 0) num.Push(line[i]);
            Console.WriteLine("i=" + i);
            int c = 0;
          
            for (i = line.Length / 2 ; i < line.Length ; i++)
            {
                 Console.WriteLine(num.Peek()+" vs "+line[i]);
                if (num.Pop() == line[i]) Console.WriteLine("Good");
                else
                { c++; Console.WriteLine("NO!"); }
            }          
                if (c > 0) Console.WriteLine("NO! is not");

            
        }
            static void Main(string[] args)
            {
                Check(Console.ReadLine());
            }
    }
}

