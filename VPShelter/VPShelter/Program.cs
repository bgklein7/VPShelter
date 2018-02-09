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
            Mogwai mogwai1 = new Mogwai("Batch 1", "Paleo", "Gizmo", "Brown and White", 5, 4, 3);
            Mogwai mogwai2 = new Mogwai("Batch 2", "South Beach", "Stripe", "Mahogany and White", 4, 5, 6);
            Mogwai mogwai3 = new Mogwai("Batch 2", "Pescatarian", "Mohawk", "Black and White", 7, 2, 5);
            Volunteer volunteer1 = new Volunteer(1234, "Ringo");
            Volunteer volunteer2 = new Volunteer(1235, "George");
            Manager manager1 = new Manager(1236, "John", 30000.00);
            
           
            int userChoice;

            Console.WriteLine("Welcome to the Virtual Pet Tender App!");
            Console.WriteLine("Congratulations on your purchase of Gizmo the Mogwai");
            Console.WriteLine("");

            do
            {
                Console.WriteLine("Mogwai: " + mogwai1.Name + " | " + mogwai2.Name + " | " + mogwai3.Name);
                Console.WriteLine("Hunger (out of 10): " + mogwai1.HungerLevel + " | " + mogwai2.HungerLevel + " | " + mogwai3.HungerLevel);
                Console.WriteLine("Thirst (out of 10): " + mogwai1.ThirstLevel + " | " + mogwai2.ThirstLevel + " | " + mogwai3.ThirstLevel);
                Console.WriteLine("Boredom (out of 10): " + mogwai1.BoredomLevel + " | " + mogwai2.BoredomLevel + "|" + mogwai3.BoredomLevel);
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
                        mogwai3.FeedMogwai();
                        break;
                    case 2:
                        mogwai3.WaterMogwai();
                        break;
                    case 3:
                        mogwai3.ActivateMogwai();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye.");
                        break;
                }

                //tick
                //userVirtualPet.TickMethod();

            } while (userChoice != 4);
        }
    }
    
}
