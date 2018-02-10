using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class VirtualPetShelter
    {
        //fields
        //invisible

        //Properties
        public List<Volunteer> AllVolunteers { get; set; }
        //public List<Mogwai> AllMogwai { get; set; }

        List<Mogwai> allMogwai = new List<Mogwai>();
        allMogwai.Add(new Mogwai());
        
            
        

        ////Methods
        //public List<string> DisplayMogwaiNames()
        //{
        //    List<string> mogwaiNames = new List<string>();
        //    foreach (VirtualPet Name in AllMogwai)
        //    {
        //        mogwaiNames.Add(mogwaiNames.Name);
        //    }
            //return mogwaiNames;






        }
}
