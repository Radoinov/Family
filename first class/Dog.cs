using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_class
{
    public class Dog
    {
        public string name;
        public string breed;
        public int age;
        public double weight;

        public void CanBark() 
        {
            Console.WriteLine($"{this.name}: Bau - bau - bauuuuuuuuuuuuuuu");

        }
        public int GrowUp() 
        { 
            return ++age;
        }
    }
}
