using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_14_3
{
    class Person
    {
        protected string name;
        protected string surname;
        protected string male;
        protected int age;
        protected int height;
        protected bool isAlive;
    
        public Person (string name="unknown" , string surname="unknown" , string male="unknown" ,int age=0 , int height=0 , bool isAlive=true) 
    
        {
            this.name = name;
            this.surname = surname;
            this.male = male;
            this.age = age;
            this.height = height;
            this.isAlive = isAlive;
            Console.WriteLine($"Name:{name} {surname} \nmale: {male}\nage :{age}\nheight :{height}\n{isAlive}");
        }
        public Person():this ("unknown", "unknown", "unknown", 0, 0, false)
        {
            Console.WriteLine("Nothing is known");
        }
        public Person(string name , string surname , int age , bool isAlive) : this(name , surname , "unknown", age, 0, isAlive)
        {
            Console.WriteLine($"{name} {surname} \nmale: {male}\nage :{age}\nheight :{height}\n{isAlive}");
        }
    }
}
