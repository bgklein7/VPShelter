using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class TypeOfPet : Gizmo
    {
        //fields
        //invisible

        //Properties
        public string Type { get; set; }
        public string Diet { get; set; }

        //Constructors
        public TypeOfPet()
        {
            //default constructor
        }

        public TypeOfPet(string type, string diet)
        {
            Type = type;
            Diet = diet;
        }

        //Methods
        
    }
}
