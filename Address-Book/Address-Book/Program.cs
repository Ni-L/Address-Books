﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    class Program
    {/// <summary>
    /// Create Main Method
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("******WelCome To Address Book******");
            AddressBook addressBook = new AddressBook(); //object of AddessBook class
            Console.WriteLine("Enter First Name :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address :");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City :");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State :");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Email :");
            int email = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Zip :");
            int zip = Convert.ToInt32(Console.ReadLine());//conver into int using ToInt32()
            Console.WriteLine("Enter Phone Number :");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            addressBook.AddContact(firstName, lastName, address, city, state, email, zip, phoneNumber);
            addressBook.ViewContact();//calling method
            addressBook.EditContact(firstName);
            addressBook.ViewContact();//calling method
            Console.Read();
        }
    }
}