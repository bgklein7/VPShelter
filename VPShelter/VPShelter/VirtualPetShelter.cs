using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    abstract class VirtualPetShelter
    {
        //fields
        //invisible

        //Properties
        public List<Volunteer> AllVolunteers { get; set; }
        public List<Mogwai> AllMogwai { get; set; }

        //Methods
        //public List<string> DisplayMogwaiNames()
        //{
        //    List<string> mogwaiNames = new List<string>();
        //    foreach ()
        //    {
        //        mogwaiNames.Add(mogwaiNames.Name);
        //    }
        //    return mogwaiNames;
        //}
    }
}
