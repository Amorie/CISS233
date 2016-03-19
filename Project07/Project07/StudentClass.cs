using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project07
{
    public class StudentClass
    {
        public StudentClass(String firstName, String lastName, String address,
        String city, String state, String zipCode,
        String phoneNumber, String phoneType, String dateOfBirth,
        String gender, String major, Decimal gpa, String graduationYear)
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
            Major = major;
            GPA = gpa;
            GraduationYear = graduationYear;
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
        public String Major { get; set; }
        public Decimal GPA { get; set; }
        public String GraduationYear { get; set; }
    }
}

