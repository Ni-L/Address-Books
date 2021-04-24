using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{/// <summary>
/// Create Interface
/// </summary>
    interface IPerson
    {
        void AddContact(string firstName, string lastName, string address, string city, string state, int email, int zip, long phoneNumber);
        void EditContact(string name);
    }
}