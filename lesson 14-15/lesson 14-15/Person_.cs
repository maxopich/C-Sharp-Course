using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_14_15
{
    class Person
    {
        private string fullName;
        public string FullName
        {
            get
            {
                return fullName;
            }
            set { fullName = value; }
        }
        private int age;
        private string nationality;
        public string Nationality
        {
            get { return nationality;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "ua":
                    case "uk":
                    case "ukraine":
                    case "ukrainian":
                        nationality = "ua";
                        break;
                    default:
                        nationality = "unkwown";
                        break;
                }
            }
        }
        public readonly long id;
        public Person(long id,string name="Unknown",int age=0,string nat="unknown0")
        {
            Console.WriteLine("caled from Person constuctor");
            this.id = id;
            fullName = name;
            this.age = age;
            Nationality = nat;
        }
        public void IncAge()
        {
            age++;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Person id:#{0}\nFull name: {1}\nAge: {2}]\nCountry: {3}",id,fullName,age,nationality);
        }


    }
}
