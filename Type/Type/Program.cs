using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name prod:");
            string p1 = Console.ReadLine();
            string p2 = Console.ReadLine();
            string p3 = Console.ReadLine();
            Console.WriteLine("Enter price:");
            int cost1 = int.Parse(Console.ReadLine());
            int cost2 = int.Parse(Console.ReadLine());
            int cost3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name of:");
            string of = Console.ReadLine();
            int cost = cost1 + cost2 + cost3;
            float ser =cost / 3f;
            Console.WriteLine();
            Console.WriteLine($"Bill: \n{p1}\t\t${cost1}\n{p2}\t\t${cost2}\n{p3}\t\t${cost3}\nYour of\t\t{of}\nyour bill\t${cost}\nSer cost\t${ser}");
            //Console.WriteLine("Enter radius:");
            //float r = float.Parse(Console.ReadLine());
            //Console.WriteLine("S="+3.14*r*r);
        }
    }
}
