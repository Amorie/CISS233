using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project07
{
    public class EmployeeClass
    {
        public EmployeeClass(String firstName, String lastName, String address,
                String city, String state, String zipCode,
                String phoneNumber, String phoneType, String dateOfBirth,
                String gender, int dependents, String ssn, String department, Decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
            PhoneNumber = phoneNumber;
            PhoneType = phoneType;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Dependents = dependents;
            SSN = ssn;
            Department = department;
            Salary = salary;
        }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String ZipCode { get; set; }
        public String PhoneNumber { get; set; }
        public String PhoneType { get; set; }
        public String DateOfBirth { get; set; }
        public String Gender { get; set; }
        public int Dependents { get; set; }
        public String SSN { get; set; }
        public String Department { get; set; }
        public Decimal Salary { get; set; }
    }
}
