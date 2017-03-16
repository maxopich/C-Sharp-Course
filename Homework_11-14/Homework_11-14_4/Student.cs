using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_14_4
{
    class Student        
    {
        private float av = 0f;
        private int[] marks;
        private string name;      
        private string homeAdress;
        public Student(string name, string homeAdress, params int[] a)
        {
            marks =  new int[a.Length];
            this.name = name;
            this.homeAdress = homeAdress;
            Console.WriteLine($"Name:{name}\nHome adress: {homeAdress}\nAverage mark{CalcAv(a)}");
        }
        private float CalcAv(params int[] a)
        {
           
        marks = a;
            for (int i = 0; i <marks.Length; i++)
            {
                av += marks[i];
            }
            return av/marks.Length;
        }
    }
}