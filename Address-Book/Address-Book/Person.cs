using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{/// <summary>
/// Adding Contact
/// </summary>
    public class Person
    {
        //Adding Get and Set Method
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Email { get; set; }
        public long PhoneNumber { get; set; }
    }
}