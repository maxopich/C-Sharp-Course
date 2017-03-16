using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine();
            Person p1 = new Person("Maks", "Opich", 19, true);
            Console.WriteLine("Name , surname , male , age , heoght, isAlive");
            Person p2 = new Person(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), bool.Parse(Console.ReadLine()));
        }
    }
}
