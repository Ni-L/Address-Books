using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{/// <summary>
/// Adding Contact Details
/// </summary>
    class Person
    {
        //Crete Variables
        string firstName;
        string lastName;
        string address;
        string city;
        string state;
        string zip;
        string phoneNumber;
        string email;

        //Adding Method
        public Person(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            //Instance Mathod
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        //Adding get Method
        public string getName()
        {
            return this.firstName;
        }
        public string getlastName()
        {
            return this.lastName;
        }
        public string getaddress()
        {
            return this.address;
        }
        public string getcity()
        {
            return this.city;
        }
        public string getstate()
        {
            return this.state;
        }
        public string getzip()
        {
            return this.zip;
        }
        public string getphone()
        {
            return this.phoneNumber;
        }
        public string getemail()
        {
            return this.email;
        }
        //Adding  Method to storing Data
        public string Tostring()
        {
            return "First Name:" + firstName + "\nLast Name:" + lastName + "\nAddress:" + address + "\nState:" + state + "\nCity:" + city + "\nZip:" + zip + "\nPhoneNumber:" + phoneNumber;
            // return "Name is:" + this.firstName +\n+ this.lastName+
        }

    }
}