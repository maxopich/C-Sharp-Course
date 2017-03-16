using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(10, 15);
            v1.Print();

            IPrintable toPrint = v1;
            toPrint.Print();


            List<Vector> vecs = new List<Vector>(new Vector[]
            {
                new Vector(0,0),
                new Vector(1,5),
 new Vector(2,1),
 new Vector(3,6),
 new Vector(4,5),
 new Vector(5,3),
 new Vector(6,2),

            });
            vecs.Sort()
            foreach(Vector v in vecs)
            {
                v.Print();
            }




























            // List<int> nums = new List<int>();
            // //nums.Add(3);
            // //nums.Add(5);
            // //nums.Add(7);
            // nums.AddRange(new int[] { 6, 8,7, 10 ,3,7,-1,2,100,57,5,4});
            // for (int i = 0; i < nums.Count; ++i)
            // {
            //     Console.WriteLine(nums[i] + " ");
            // }
            // Console.WriteLine();
            // nums.Insert(0, 15);
            // nums.Remove(8);
            // nums.Sort();
            // Console.WriteLine(nums.Contains(7));
            //// nums.RemoveAll((x=>x==7));
            // foreach(int num in nums)
            // {
            //     Console.Write(num+" ");
            // }
            // Console.WriteLine( );
            //SortedSet<int> nums = new SortedSet<int>(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            //foreach(int num in nums)
            //{
            //    Console.Write(num+" ");
            //}
            //Stack<int> stecknums = new Stack<int>();
            //stecknums.Push(15);
            //stecknums.Push(10);
            //Console.WriteLine(stecknums.Pop());
            //foreach (int num in stecknums)
            //{
            //    Console.WriteLine(num+" ");
            //}
            //Console.WriteLine();

            //Console.WriteLine();
        }
    }
}
