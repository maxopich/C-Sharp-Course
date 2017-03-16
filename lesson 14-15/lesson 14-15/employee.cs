using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_14_15
{
    class Employee : Person
    {
        public const float minSalary = 1300;
        public string Company { get; set; }

        public Car companyCar;

        private float salary;

        public float Salary
        {
            get { return salary; }
            set
            {
                if (value < minSalary)
                {
                    salary = 1300;
                    Console.WriteLine("Warning : Salary sset to $1300$");
                }
            }
        }
        public Employee(long id, string name = "Unknown", string company="Epam",float salary=1000):base(id,name)
        {
            Console.WriteLine("caled from employee constuctor");
            Company = company;
            Salary = salary;
        }
    }
}
