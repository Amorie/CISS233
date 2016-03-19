using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03StudentEmployeeEntry
{
    class EmployeeClass
    {
        private string name;
        private string department;
        private double salary;

        public EmployeeClass (string empName, string empDept, double empSalary)
        {
            name = empName;
            department = empDept;
            salary = empSalary;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
    }
  
}
