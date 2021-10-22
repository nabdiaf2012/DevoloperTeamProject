using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodInsuraneClassLibrary
{
    public class DevTeam
    {
        public DevTeam()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Developer> Members { get; set; }

       
    }
}
