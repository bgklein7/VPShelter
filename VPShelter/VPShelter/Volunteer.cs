using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        //Fields

        private bool afterMidnight;
        private bool spilledOnMogwai;
        private bool isLightOut;
        //private int boredomLevel;
        private int foodAmount;
        //private int hungerLevel;
        //private int thirstLevel;
        private int activityAmount;
        private int beverageAmount;

        //Properties

        public bool AfterMidnight
        {
            get { return this.afterMidnight; }
            set { this.afterMidnight = value; }
        }

        public bool SpilledOnMogwai
        {
            get { return this.spilledOnMogwai; }
            set { this.spilledOnMogwai = value; }
        }

        public bool IsLightOut
        {
            get { return this.isLightOut; }
            set { this.isLightOut = value; }
        }

        public int BeverageAmount
        {
            get { return this.beverageAmount; }
            set { this.beverageAmount = value; }
        }

        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }
        }

        public int ActivityAmount
        {
            get { return this.activityAmount; }
            set { this.activityAmount = value; }
        }

        //public int BoredomLevel
        //{
        //    get { return this.boredomLevel; }
        //    set { this.boredomLevel = value; }
        //}

        //public int ThirstLevel
        //{
        //    get { return this.thirstLevel; }
        //    set { this.thirstLevel = value; }
        //}

        //public int HungerLevel
        //{
        //    get { return this.hungerLevel; }
        //    set { this.hungerLevel = value; }
        //}

        //Constructors
        public Volunteer()
        {
            //default constructor
        }

        public Volunteer(int employeeID, string employeeName)
        {
            
        }

        //Methods
        public string WaterMogwai()
        {
            Console.WriteLine("Do you want to give the mogwai something to drink? (True or False");
            bool beverageResponse;
            beverageResponse = bool.Parse(Console.ReadLine());
            if (beverageResponse == true)
            {
                return "Mogwai have been given something to drink.";
            }
            else
            {
                return "Mogwai have not been given anything to drink.";
            }
            //if (thirstLevel >= 1)
            //{
            //    Console.WriteLine("Mogwai has been given some water.");

            //    Console.WriteLine("Did you spill on mogwai? (type True or False)");
            //    spilledOnMogwai = bool.Parse(Console.ReadLine());

            //    if (spilledOnMogwai == true)
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
            //    return thirstLevel--;
            //}

            //else
            //{
            //    Console.WriteLine("Mogwai does not need anything to drink.");
            //    return thirstLevel++;
            //}
        }


        
        

    //public int TickMethod()
    //{
    //    return boredomLevel++ + hungerLevel++ + thirstLevel++;
    //}

    public override bool ShowID()
        {
            if(EmployeeID/2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string Uniform()
        {
            return "Name tag only";
        }
    }
}
