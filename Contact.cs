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

        //Method to add contact
        public static Contact AddContact()
        {
            Contact contact = new Contact(); //created object to store user input

            Console.WriteLine("Please enter the contact details:");
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

            return contact; //returning object to store in list

        }

        //Method to diplay added contacts
        public static void DisplayContact(List<Contact> addressBook)
        {
            if (addressBook.Count == 0) //if no contact found(empty list/Address Book)
                Console.WriteLine("No Contact Added!!!");
            else
            {
                for (int i = 0; i < addressBook.Count; i++)
                {
                    Console.WriteLine(addressBook[i]); 
                }
            }
        
        }

        //Method to edit contact based on name
        public static void EditContact(List<Contact> addressBook)
        {
            int contactFound = 0;

            if (addressBook.Count == 0) //if no contact found(empty list/Address Book)
                Console.WriteLine("No Contact Added!!!");
            else
            {
                Console.Write("Enter the Contact First Name : ");
                string newFirstName = Console.ReadLine();
                Console.Write("Enter the Contact First Name : ");
                string newLastName = Console.ReadLine();

                for (int i = 0; i < addressBook.Count; i++)
                {
                    if (addressBook[i].firstName == newFirstName && addressBook[i].lastName == newLastName)
                    {
                        Console.WriteLine("Please input the new values for contact");
                        addressBook[i] = Contact.AddContact();
                        contactFound = 1;
                    }
                }
                if (contactFound == 0)
                    Console.WriteLine("Contact Information you entered not found. Please check added contacts and then try again!!!!");
            }
        }

        //method to delete contact based on name
        public static void DeleteContact(List<Contact> addressBook)
        {
            int foundContact = 0; //flag to check if contact found

            if (addressBook.Count == 0) //if no contact found(empty list/Address Book)
                Console.WriteLine("No Contact Added");
            else
            {
                Console.Write("Enter the Contact First Name : ");
                string newFirstName = Console.ReadLine();
                Console.Write("Enter the Contact First Name : ");
                string newLastName = Console.ReadLine();

                for (int i = 0; i < addressBook.Count; i++)
                {
                    if (addressBook[i].firstName == newFirstName && addressBook[i].lastName == newLastName)
                    {
                        Console.WriteLine("Deleting: " + addressBook[i].firstName + " " + addressBook[i].lastName + " Contact details...");
                        addressBook.Remove(addressBook[i]);
                        foundContact = 1; //changing flag value as contact found and deleted
                    }

                }
                if (foundContact == 0) //contact not found
                    Console.WriteLine("Contact Information you entered not found. Please check added contacts and then try again!!!!");
            }

        }

        public override string ToString() //overriding ToString method of Object class to diplay the objects
        {
            return "\nFirst Name : " + this.firstName + "\nLast Name : " + this.lastName + "\nAddress: " + this.address + "\nCity: " + this.city + "\nState: " + this.state + "\nZip Code: " + this.zipCode + "\nPhone Number: " + this.phoneNumber + "\nEmail: " + this.email;
        }
    }
}
