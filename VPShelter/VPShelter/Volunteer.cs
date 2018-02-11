using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        //fields
        //invisible

        //Properties
        public string Allergies { get; set; }

       

        //Constructors
        public Volunteer()
        {
            //default constructor
        }

        public Volunteer(int employeeID, string employeeName)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
        }

        //Methods
        
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

        public void FeedPets()
        {
            Console.WriteLine("You fed them.");
        }

        public void WaterPets()
        {
            Console.WriteLine("You gave them water.");
        }
    }
}
