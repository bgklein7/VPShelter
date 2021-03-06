﻿using System;
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
        
    }
}
