using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_14_2
{
    class Product
    {
        protected float price;
        protected string category;
        protected string name;
        public Product(float price =0 , string category= "unknown" , string name="unknown")
        {
            this.price = price;
            this.category = category;
            
            this.name = name;
            if (category == "For children") { PrintInfo(); }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Category: {category}\nName: {name}\nPrice:{price}");
        }
    }
}
