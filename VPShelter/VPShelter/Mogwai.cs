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
        public bool AfterMidnight { get; set; }
        public bool SpilledOnMogwai { get; set; }
        public bool IsLightOut { get; set; }
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
            Name = name;
            Description = description;
            HungerLevel = hungerLevel;
            BoredomLevel = boredomLevel;
            ThirstLevel = thirstLevel;
        }

        //Methods
        public int FedMogwai()
        {
            if (HungerLevel >= 1)
            {
                Console.WriteLine(Name + " has been fed based on a " + Diet + " diet.");

                Console.WriteLine("Is it after midnight? (type True or False)");
                AfterMidnight = bool.Parse(Console.ReadLine());

                if (AfterMidnight == true)
                {
                    Console.WriteLine(Name + " is now a gremlin!");
                    Console.WriteLine("");
                    Console.Title = "ASCII Art";
                    string title = @"
                    _______
                   /       \
            \-----`  ^  ^   `----/
             \ ` `   *  *     ``/
              `---|         |--`
                  \  `--`  /
                   \  \/  /
                    \    /
                     \  /
                      \/
                                                                 ";

                    Console.WriteLine(title);
                }

                else
                {
                    Console.WriteLine("All is good.");
                    Console.WriteLine("");

                }
                return HungerLevel-- + ThirstLevel++;
            }
            else
            {
                Console.WriteLine(Name + "does not need to be fed.");
                Console.WriteLine("");
                return HungerLevel++;
            }
        }

        public int WateredMogwai()
        {
            if (ThirstLevel >= 1)
            {
                Console.WriteLine(Name + " has been given some water.");

                Console.WriteLine("Did you spill on " + Name + "? (type True or False)");
                SpilledOnMogwai = bool.Parse(Console.ReadLine());

                if (SpilledOnMogwai == true)
                {
                    Console.WriteLine(Name + " is now a gremlin!");
                    Console.WriteLine("");
                    Console.Title = "ASCII Art";
                    string title = @"
                    _______
                   /       \
            \-----`  ^  ^   `----/
             \ ` `   *  *     ``/
              `---|         |--`
                  \  `--`  /
                   \  \/  /
                    \    /
                     \  /
                      \/
                                                                 ";

                    Console.WriteLine(title);

                }

                else
                {
                    Console.WriteLine("All is good.");
                    Console.WriteLine("");

                }
                return ThirstLevel--;
            }

            else
            {
                Console.WriteLine(Name + " does not need anything to drink.");
                return ThirstLevel++;
            }
           
        }

        public int PlayedWithMogwai()
        {
            if (BoredomLevel >= 1)
            {
                Console.WriteLine(Name + " has been allowed out to play");

                Console.WriteLine("Is it light out? (type True or False)");
                IsLightOut = bool.Parse(Console.ReadLine());

                if (IsLightOut == true)
                {
                    Console.WriteLine("That hurt " + Name + "! Quick! Get back inside!");
                    Console.WriteLine("");
                    return HungerLevel++ + ThirstLevel++ + BoredomLevel++;//to make go up by more than one use +=10
                }

                else
                {
                    Console.WriteLine("All is good!");
                    Console.WriteLine("");
                    return BoredomLevel-- + HungerLevel++ + ThirstLevel++;
                }
            }

            else
            {
                Console.WriteLine(Name + " needs to sleep.");
                return BoredomLevel++;
            }
            
        }

        public int TickMethod()
        {
            return BoredomLevel++ + HungerLevel++ + ThirstLevel++;
        }


    }
}
