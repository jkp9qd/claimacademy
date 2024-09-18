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

            Console.WriteLine("Welcome to PotterEnterprise Phonebook");
            Console.WriteLine("Select Operation");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contact by Number");
            Console.WriteLine("3. View All Contacts");
            Console.WriteLine("4. Search For Contacts By Name");
            Console.WriteLine("5. Exit");


            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            switch (userInput) 
            {
                case "1":
                    Console.WriteLine("Contact Name:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Contact Number");
                    var number = Console.ReadLine();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Select Valid Operation");
                    break;
            }




        }
    }
}
