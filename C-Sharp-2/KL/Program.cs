using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace KL
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 10f;
            float k = 0f;
            double z;
            float x;

        Ex:

            try
            {
                x = float.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error :" + ex + "\n.\n.\n.\n.");
                Console.WriteLine("Try again");
                goto Ex;

            }
            if (Abs(x) < 1)
            {
                k++;
            }
            if (Abs(x % 1) > 0)
            {
                do
                {
                    x *= 10;
                } while (Abs(x % 1) != 0);
                }
            Console.WriteLine("X before = "+x+"\n");
            do
            {
                z = x / a;
                a *= 10;
                Console.WriteLine("Iteration "+z);
                k++;
            } while (Abs(z)>1);
            Console.WriteLine("\nNumbers of digits :"+k);



            }
    }
}
