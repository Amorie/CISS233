/*
Paul Adams
Project 6 Customer Entry
3/1/16
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project06CustomerEntry
{
    public class ClassCustomer
    {
        public ClassCustomer(string firstName, string lastName, string street, string city, string state, string zip, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            StreetAddress = street;
            State = state;
            City = city;
            Zip = zip;
            Phone = phone;
        }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string StreetAddress { set; get; }
        public string State { set; get; }
        public string City { set; get; }
        public string Zip { set; get; }
        public string Phone { set; get; }
    }
}
