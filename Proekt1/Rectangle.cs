using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt1
{
    internal class Rectangle
    {
        public int a;
        public int b;

        public int NameriPerimetyra(int a, int b) 
        { 
            return (a + b)+2;
        }

        public int FindArea(int a, int b) 
        { 
            return a * b;
        }


    }
}
