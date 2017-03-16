using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_14_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 30; ;
            Random x = new Random();
            Runner[] run = new Runner[5];
            for (int i = 0; i < run.Length; i++)
            {
                run[i] = new Runner(Console.ReadLine(), x.Next(10, 30));
            }
            for (int i = 0; i < run.Length; i++)
            {
                if (run[i].Time < temp)
                {
                    temp = run[i].Time;
                }
            }
            Console.WriteLine(temp);
        }
    }

}
