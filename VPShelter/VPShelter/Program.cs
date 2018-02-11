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
            
            
            do
            {
                Console.WriteLine("Welcome to the Mr. Wing's Pet Shelter!");
                Console.WriteLine("What employee type are you?");
                Console.WriteLine("Type 1 for Manager.");
                Console.WriteLine("Type 2 for Volunteer.");
                Console.WriteLine("Type 3 to Quit.");

                userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 1)
                {
                    Console.WriteLine("Welcome, Manager");
                    do
                    {
                        Console.WriteLine("Mogwai: " + mogwai1.Name + " | " + mogwai2.Name + " | " + mogwai3.Name);
                        Console.WriteLine("Hunger (out of 10): " + mogwai1.HungerLevel + " | " + mogwai2.HungerLevel + " | " + mogwai3.HungerLevel);
                        Console.WriteLine("Thirst (out of 10): " + mogwai1.ThirstLevel + " | " + mogwai2.ThirstLevel + " | " + mogwai3.ThirstLevel);
                        Console.WriteLine("Boredom (out of 10): " + mogwai1.BoredomLevel + " | " + mogwai2.BoredomLevel + " | " + mogwai3.BoredomLevel);
                        Console.WriteLine("");
                        Console.WriteLine("What would you like to do for the mogwai?");
                        Console.WriteLine("Adopt mogwai, type 1");
                        Console.WriteLine("Feed mogwai, type 2");
                        Console.WriteLine("Play with the mogwai, type 3");
                        Console.WriteLine("To exit Manager sub-menu, type 4");

                        userChoice = int.Parse(Console.ReadLine());

                        switch (userChoice)
                        {
                            case 1:
                                Console.WriteLine("Which mogwai would you like to adopt: " + mogwai1.Name + " (" + mogwai1.Description + "), " + mogwai2.Name + " (" + mogwai2.Description +  "), or " + mogwai3.Name + " (" + mogwai3.Description + ")?");
                                string adoptee = Console.ReadLine();
                                Console.WriteLine(adoptee + " is an excellent choice.");
                                manager1.AdoptMogwai();
                                break;
                            case 2:
                                mogwai1.FedMogwai();
                                mogwai2.FedMogwai();
                                mogwai3.FedMogwai();
                                break;
                            case 3:
                                Console.WriteLine("Which mogwai do you wish to play with?");
                                Console.WriteLine("Type 1 for " + mogwai1.Name + ".");
                                Console.WriteLine("Type 2 for " + mogwai2.Name + ".");
                                Console.WriteLine("Type 3 for " + mogwai3.Name + ".");
                                int playmate = int.Parse(Console.ReadLine());
                                if (playmate == 1)
                                {
                                    mogwai1.PlayedWithMogwai();
                                    break;
                                }
                                if (playmate == 2)
                                {
                                    mogwai2.PlayedWithMogwai();
                                    break;
                                }
                                if (playmate == 3)
                                {
                                    mogwai3.PlayedWithMogwai();
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            case 4:
                                Console.WriteLine("You have exited the Manager sub-menu.");
                                Console.WriteLine("");
                                break;
                        }

                        //tick
                        mogwai1.TickMethod();
                        mogwai2.TickMethod();
                        mogwai3.TickMethod();

                    } while (userChoice != 4);
                    
                }
                if (userChoice == 2)
                {

                    Console.WriteLine("Welcome, Volunteer!");
                    do
                    {
                        Console.WriteLine("Mogwai: " + mogwai1.Name + " | " + mogwai2.Name + " | " + mogwai3.Name);
                        Console.WriteLine("Hunger (out of 10): " + mogwai1.HungerLevel + " | " + mogwai2.HungerLevel + " | " + mogwai3.HungerLevel);
                        Console.WriteLine("Thirst (out of 10): " + mogwai1.ThirstLevel + " | " + mogwai2.ThirstLevel + " | " + mogwai3.ThirstLevel);
                        Console.WriteLine("Boredom (out of 10): " + mogwai1.BoredomLevel + " | " + mogwai2.BoredomLevel + " | " + mogwai3.BoredomLevel);
                        Console.WriteLine("");
                        Console.WriteLine("What would you like to do for the mogwai?");
                        Console.WriteLine("Feed mogwai, type 1");
                        Console.WriteLine("Give the mogwai something to drink, type 2");
                        Console.WriteLine("Play with the mogwai, type 3");
                        Console.WriteLine("To exit Volunteer sub-menu, type 4");

                        userChoice = int.Parse(Console.ReadLine());

                        switch (userChoice)
                        {
                            case 1:
                                volunteer1.FeedPets();
                                mogwai1.FedMogwai();
                                mogwai2.FedMogwai();
                                mogwai3.FedMogwai();
                                break;
                            case 2:
                                volunteer1.WaterPets();
                                mogwai1.WateredMogwai(); 
                                mogwai2.WateredMogwai();
                                mogwai3.WateredMogwai();
                                break;
                            case 3:
                                Console.WriteLine("Which mogwai do you wish to play with?");
                                Console.WriteLine("Type 1 for " + mogwai1.Name + ".");
                                Console.WriteLine("Type 2 for " + mogwai2.Name + ".");
                                Console.WriteLine("Type 3 for " + mogwai3.Name + ".");
                                int playmate = int.Parse(Console.ReadLine());
                                if (playmate == 1)
                                {
                                    mogwai1.PlayedWithMogwai();
                                    break;
                                }
                                if (playmate == 2)
                                {
                                    mogwai2.PlayedWithMogwai();
                                    break;
                                }
                                if (playmate == 3)
                                {
                                    mogwai3.PlayedWithMogwai();
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                                
                            case 4:
                                Console.WriteLine("You have exited the Volunteer sub-menu.");
                                Console.WriteLine("");
                                break;
                        }

                        //tick
                        mogwai1.TickMethod();
                        mogwai2.TickMethod();
                        mogwai3.TickMethod();

                    } while (userChoice != 4);
                }
                else
                {

                    Console.WriteLine("Goodbye.");
                    break;
                }
            } while (userChoice != 3);
               
            
        }

    }
}
