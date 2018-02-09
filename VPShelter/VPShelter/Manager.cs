using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee
    {
        //fields
        //invisible

        //Properties
        public double Salary { get; set; }

        //Constructors
        public Manager()
        {
            //default constructor
        }

        public Manager(int employeeID, string employeeName, double salary)
        {
            Salary = salary;
        }

        //Methods
        public override bool ShowID()
        {
            if (EmployeeID / 2 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string Uniform()
        {
            return "Shirt and name tag";
        }

        public bool MogwaiAdoption()
        {
            Console.WriteLine("Did you tell the adopter the three rules of owning a mogwai?(True or False");
            return bool.Parse(Console.ReadLine());
        }

    }
}
