using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User input 

            Console.WriteLine("Welcome to PotterEnterprise Phonebook");
            Console.WriteLine("Add your First Name Here");

            string firstname = Console.ReadLine();
            Console.WriteLine(firstname);

            Console.WriteLine("Add your Last Name Here");

            string lastname = Console.ReadLine();
            Console.WriteLine(lastname);

            Console.WriteLine("Add your Phone Number Here");

            string phonenumber = Console.ReadLine();
            Console.WriteLine(phonenumber);

            Console.WriteLine("Your Full Name is : " + firstname);

        }
    }
}
