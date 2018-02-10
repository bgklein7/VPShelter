using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        //fields
        //invisible

        //Properties
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }

        //Constructors
        public Employee()
        {
            //default constructor
        }

        public Employee(int employeeID, string employeeName)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
        }

        //Methods- Abstract
        public abstract bool ShowID();
        public abstract string Uniform();

        //Methods
        public string FeedMogwai()
        {
            Console.WriteLine("Do you want to feed the mogwai? (True or False");
            bool feedResponse;
            feedResponse = bool.Parse(Console.ReadLine());
            if (feedResponse == true)
            {
                return "Mogwai have been fed.";
            }
            else
            {
                return "Mogwai have not been fed.";
            }
            //if (HungerLevel >= 1)
            //{
            //    Console.WriteLine("Mogwai has been fed.");

            //    Console.WriteLine("Is it after midnight? (type True or False)");
            //    afterMidnight = bool.Parse(Console.ReadLine());

            //    if (afterMidnight == true)
            //    {
            //        Console.WriteLine("Mogwai is now a gremlin!");
            //        Console.WriteLine("");
            //        Console.Title = "ASCII Art";
            //        string title = @"
            //        _______
            //       /       \
            //\-----`  ^  ^   `----/
            // \ ` `   *  *     ``/
            //  `---|         |--`
            //      \  `--`  /
            //       \  \/  /
            //        \    /
            //         \  /
            //          \/
            //                                                     ";

            //        Console.WriteLine(title);
            //    }

            //    else
            //    {
            //        Console.WriteLine("All is good.");
            //        Console.WriteLine("");

            //    }
            //    return hungerLevel-- + thirstLevel++;
            //}
            //else
            //{
            //    Console.WriteLine("Mogwai does not need to be fed.");
            //    Console.WriteLine("");
            //    return hungerLevel++;
            //}

        }
        public string ActivateMogwai()
        {
            Console.WriteLine("Do you want play with the mogwai? (True or False)");
            bool playResponse;
            playResponse = bool.Parse(Console.ReadLine());
            if (playResponse == true)
            {
                return "You have played with the mogwai.";
            }
            else
            {
                return "You have not played with the mogwai.";
            }
        }    
        //if (boredomLevel >= 1)
        //{
        //    Console.WriteLine("Mogwai has been allowed out to play");

        //    Console.WriteLine("Is it light out? (type True or False)");
        //    isLightOut = bool.Parse(Console.ReadLine());

        //    if (isLightOut == true)
        //    {
        //        Console.WriteLine("That hurt the mogwai! Quick! Get back inside!");
        //        Console.WriteLine("");
        //        return hungerLevel++ + thirstLevel++ + boredomLevel++;//to make go up by more than one use +=10
        //    }

        //    else
        //    {
        //        Console.WriteLine("All is good!");
        //        Console.WriteLine("");
        //        return boredomLevel-- + hungerLevel++ + thirstLevel++;
        //    }
        //}

        //else
        //{
        //    Console.WriteLine("Mogwai needs to sleep.");
        //    return boredomLevel++;
        //}
    }
}
