using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03StudentEmployeeEntry
{
    class StudentClass
    {

        private string name;
        private string major;
        private string graduationYear;
        private double gpa;

        public StudentClass (string studentName, string studentMajor, string studentGradYear, double studentGpa)
        {
            name = studentName;
            major = studentMajor;
            graduationYear = studentGradYear;
            gpa = studentGpa;
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
        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }
        public string GraduationYear
        {
            get
            {
                return graduationYear;
            }
            set
            {
                graduationYear = value;
            }
        }
        public double GPA
        {
            get
            {
                return gpa;
            }
            set
            {
                gpa = value;
            }
        }
    }
}
