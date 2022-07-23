namespace AddressBookSystem
{ /// <summary>
  /// UC2 : Ability to add new Contact to the Address Book
  /// </summary>
    public class Program
    {   //An entrypoint of Console App
        static void Main(string[] args)
        {
            List<Contact> addressBook = new List<Contact>(); //Creating list to store the contact of Contact Type Class
            int option;
            Console.WriteLine("Welcome to the Address book");

            //Loop to continue adding contact until user wants to exit
            do   
            {
                Console.WriteLine("\nEnter from the below options:");
                Console.WriteLine("1. Add new contact");
                Console.WriteLine("2. Exit");

                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                    addressBook.Add(Contact.AddContact()); //Contact.AddContact() return object, storing object to addressBook
                else
                    Console.WriteLine("Enter valid option");
                

            } while (option != 2); //continue till user wants to add contact
        }
    }
}