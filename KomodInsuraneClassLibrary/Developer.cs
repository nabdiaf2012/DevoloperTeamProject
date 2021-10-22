using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodInsuraneClassLibrary
{
    public class Developer
    {
        public Developer() //Default Constructor 
        {
        }

        public Developer(int id, string name, bool sight)//overloaded Constructor
        {
            DeveloperId = id;
            DeveloperName = name;
            HasPluralsightAccess = sight;
        }

        public int DeveloperId { get; set; } 
        public string DeveloperName { get; set; }
        public bool HasPluralsightAccess { get; set; }
    }
}


