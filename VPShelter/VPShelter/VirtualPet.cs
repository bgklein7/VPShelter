using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    {
        //fields
        //invisible

        //Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public int BoredomLevel { get; set; }
        public int ThirstLevel { get; set; }
        public int HungerLevel { get; set; }

        //Constructors
        public VirtualPet()
        {
            //default constructor
        }

        public VirtualPet(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public VirtualPet(string name, string description, int hungerLevel, int boredomLevel, int thirstLevel)
        {
            Name = name;
            Description = description;
            BoredomLevel = boredomLevel;
            ThirstLevel = thirstLevel;
            HungerLevel = hungerLevel;

            
            
        }

    }
}
