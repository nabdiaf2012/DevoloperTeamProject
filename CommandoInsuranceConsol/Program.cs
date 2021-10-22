
using KomodInsuraneClassLibrary;
using System;
using System.Collections.Generic;

namespace CommandoInsuranceConsol
{
    class Program
    {
        static void Main(string[] args)
        {

            Developer dev = new Developer();
            dev.DeveloperId = 2;
            dev.DeveloperName = "Erick";
            dev.HasPluralsightAccess = false;

            Developer dev2 = new Developer(1, "Nabil", true);

            List<int> test = new List<int>();

            test.Add(34);


        }
    }
}
