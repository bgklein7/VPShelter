using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Mogwai : VirtualPet
    {
        //fields
        //invisible

        //Properties
        public string Type { get; set; }
        public string Diet { get; set; }

        //Constructors
       
        public Mogwai()
        {

        }

        public Mogwai(string type, string diet, string name, string description, int hungerLevel, int boredomLevel, int thirstLevel)
        {
            Type = type;
            Diet = diet;
        }

        //Methods

        //public int FedMogwai()
        //{
        //    if()
        //}

        
    }
}
