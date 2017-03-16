using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace MaxExam
{
    public abstract class Rotatable
    {
        public string Line { get; set; }

        protected Rotatable(string line)
        {
            Line = line;
        }

        public abstract string Rotate();
    }

    class Rotator : Rotatable
    {
        public Rotator(string line) : base(line)
        {
        }

        public override string Rotate()
        {
            string endLine = "";

            Stack<string> words = new Stack<string>();

            foreach (var word in Line.Split())
            {
                words.Push(word);
            }

            foreach (var w in words)
            {
                endLine += w + " ";
            }

            return endLine.Trim();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rotator r = new Rotator("Hello my friend bob");
            Console.WriteLine(r.Rotate());
            
        }
    }
}