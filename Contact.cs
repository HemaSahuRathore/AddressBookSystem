using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {   
        //Variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zipCode;
        public long phoneNumber;
        public string email;
        public static Contact AddContact()
        {
            Contact contact = new Contact();

            Console.WriteLine("Please enter the new contact details:");
            Console.Write("First Name: ");
            contact.firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            contact.lastName = Console.ReadLine();
            Console.Write("Address: ");
            contact.address = Console.ReadLine();
            Console.Write("City: ");
            contact.city = Console.ReadLine();
            Console.Write("State: ");
            contact.state = Console.ReadLine();
            Console.Write("Zip Code: ");
            contact.zipCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phone Number: ");
            contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email: ");
            contact.email = Console.ReadLine();

            return contact;

        }
    
    }
}
