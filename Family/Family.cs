﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    internal class Family
    {
        private string familyname;
        public string FamilyName
        {
            get { return familyname; }
            set { familyname = value; }
        }

        private List<Person> members = new List<Person>();
       public List<Person> Members
        {
            get
            {
                return members;
            }
            set
            { 
                members = value;
            }
        }

        public void PrintAllFamily() 
        {
            Console.WriteLine($"Family: {this.FamilyName}");
            foreach ( Person item in this.Members )
            {
                
            }
        }
    }
}
