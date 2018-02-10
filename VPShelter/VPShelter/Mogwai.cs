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
        //    Volunteer.FeedMogwai()
        //        {
        //        return mogwai1.HungerLevel++;
        //        }
            //if (Volunteer.FeedMogwai() == "The mogwai have been fed.")
            //{
            //    return mogwai1.HungerLevel--;
            //}
            //else
            //{
            //    return mogwai1.HungerLevel++;
            //}
        //}


    }
}
