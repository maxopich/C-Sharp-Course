using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        public static float Obr (float km)
        {
            float sum;
            if (km <= 10.0f)
            {
                return sum = 30.0f + 5.0f * km;                
            }
            else if (km>10.0f && km <= 20.0f)
            {
                return sum = 30.0f + 4.0f * km;              
            }
            else
            {
                return sum = 30.0f + 3.0f * km;                
            }                      
        }
        static void Main(string[] args)
        {        
            Console.WriteLine("Enter km");
            float km = float.Parse(Console.ReadLine());
        Error:
            Console.WriteLine("Enter day\\night :");
            string time = Console.ReadLine();
            switch (time)
            {
                case "day": Console.WriteLine("The price of your trip "+Obr(km)+"$");  break;
                case "night": Console.WriteLine("The price of your trip " + Obr(km)/2+"$");  break;
                default: Console.WriteLine("Error"); goto Error;
            }
            
        }
    }
}
