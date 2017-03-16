using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_14_5
{
    class Runner
    {
        public int temptime = 30;
        private string name;
        private int time;
        public int Time
        {
            get;
            set;
        }
        public Runner(string name, int time)
        {
            
            this.name = name;
            this.time = time;
            Time = time;
            Console.WriteLine($"Name:{name}\t{time}");
           
          
        }
       
    }
}