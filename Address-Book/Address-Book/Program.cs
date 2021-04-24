using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    class Program
    {/// <summary>
    /// Main Mathod
    /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("******WelCome To Address Book******");
            //Display Contact
            Person person = new Person("Naina", "Wadal", "akola", "pune", "maharashtra", "444101", "7363353435", "nilimawadal1@gmail.com");
            Console.WriteLine(person.getName());
            Console.WriteLine(person.getlastName());
            Console.WriteLine(person.getaddress());
            Console.WriteLine(person.getcity());
            Console.WriteLine(person.getstate());
            Console.WriteLine(person.getzip());
            Console.WriteLine(person.getphone());
            Console.WriteLine(person.getemail());
            //contacts.FirstName = Naina
            Console.Read();
        }



    }
}
        
