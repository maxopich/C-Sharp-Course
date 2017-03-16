using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19_20
{
    class Program
    {
        public static void Check(string line)
        {
           
            Stack<char> num = new Stack<char>();
            for(int i = 0; i<line.Length;i++)
            {
                if (line[i] == '1')
                {
                    num.Push(line[i]);                                        
                }                      
            }
            if (num.Count >= 2 && (num.Count %2) ==0 ) Console.WriteLine("true\t"+num.Count);
            else  Console.WriteLine("false\t"+num.Count);   
                     
        }
   static void Main(string[] args)
     {

            Check(Console.ReadLine());
      }
   }
}
