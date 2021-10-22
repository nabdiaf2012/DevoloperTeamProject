using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodInsuraneClassLibrary
{
    //CRUD METHODS GO HERE

    public class DeveloperRepo
    {
        private List<Developer> _listOfDevelopers = new List<Developer>(); //All my methods van see my list becuase my list was declared in the global scope

        public void AddDeveloper(Developer developer)
        {
            _listOfDevelopers.Add(developer);
        }

        public Developer Read(int developerId)
        {
            return null;
        }

        public void Update(Developer developer)
        {
           
        }

        public void Delete(int developerId)
        {

        }
    }
}

