using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Volunteer userMogwai = new Volunteer(5, 5, 5);
            int userChoice;

            Console.WriteLine("Welcome to the Virtual Pet Tender App!");
            Console.WriteLine("Congratulations on your purchase of Gizmo the Mogwai");
            Console.WriteLine("");

            do
            {
                Console.WriteLine("Gizmo the Mogwai");
                Console.WriteLine("Hunger: " + userMogwai.HungerLevel + " out of 10");
                Console.WriteLine("Thirst: " + userMogwai.ThirstLevel + " out of 10");
                Console.WriteLine("Boredom: " + userMogwai.BoredomLevel + " out of 10");
                Console.WriteLine("");
                Console.WriteLine("What would you like to do for the mogwai?");
                Console.WriteLine("Feed mogwai, type 1");
                Console.WriteLine("Give the mogwai something to drink, type 2");
                Console.WriteLine("Play with the mogwai, type 3");
                Console.WriteLine("To quit, type 4");

                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        userMogwai.FeedMogwai();
                        break;
                    case 2:
                        userMogwai.WaterMogwai();
                        break;
                    case 3:
                        userMogwai.ActivateMogwai();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye.");
                        break;
                }

                //tick
                userMogwai.TickMethod();

            } while (userChoice != 4);
        }
    }
    
}
