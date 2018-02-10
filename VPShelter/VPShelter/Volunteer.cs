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
        //inherited only

       

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
    }
}
