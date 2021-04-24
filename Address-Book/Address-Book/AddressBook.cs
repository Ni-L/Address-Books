using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{/// <summary>
/// Create Class For Address Book
/// </summary>
    class AddressBook : IPerson
    {
        //Creating Disctionary of Person to storing Data 
        private Dictionary<string, Person> people = new Dictionary<string, Person>();
        //Adding Method
        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber)
        {
            //Create Object of Person Class 
            Person contact = new Person();
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.Address = address;
            contact.City = city;
            contact.State = state;
            String Email = email;
            int Zip = zip;
            contact.PhoneNumber = phoneNumber;
            people.Add(contact.FirstName, contact);
        }
        //Adding Method to View Contact
        public void ViewContact()
        {
            foreach (KeyValuePair<string, Person> view in people)
            {
                Console.WriteLine("First Name : " + view.Value.FirstName);
                Console.WriteLine("Last Name : " + view.Value.LastName);
                Console.WriteLine("Address : " + view.Value.Address);
                Console.WriteLine("City : " + view.Value.City);
                Console.WriteLine("State : " + view.Value.State);
                Console.WriteLine("Email : " + view.Value.Email);
                Console.WriteLine("Zip : " + view.Value.Zip);
                Console.WriteLine("Phone Number : " + view.Value.PhoneNumber + "\n");
            }
        }
    }
}