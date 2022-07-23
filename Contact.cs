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

        //Constuctor - Can initialize value while creating object
        public Contact()
        {
            Console.WriteLine("Please enter the new contact details:");
            Console.Write("First Name: ");
            this.firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            this.lastName = Console.ReadLine();
            Console.Write("Address: ");
            this.address = Console.ReadLine();
            Console.Write("City: ");
            this.city = Console.ReadLine();
            Console.Write("State: ");
            this.state = Console.ReadLine();
            Console.Write("Zip Code: ");
            this.zipCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phone Number: ");
            this.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email: ");
            this.email = Console.ReadLine();
        }
    }
}
