using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    interface IPerson
    {
        void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber);

    }
}