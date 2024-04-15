using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    internal class Person
    {
        private string ime;
        private int age;
        public string Name
        {
            get
            {
                return ime;
            }

            set {ime = value; }


        }   

        public int Age 
        {
            get 
            { 
                return age;
            }
            set
            {
                if (value < 0 || value > 117)
                {
                    Console.WriteLine("Nevalidni godini za vyzrast!");
                    this.age = 0;
                }
                else 
                { 
                    this.age = value;
                }
                this.age = value; 
            }
        }

    }
}
