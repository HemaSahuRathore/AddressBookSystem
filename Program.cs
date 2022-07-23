namespace AddressBookSystem
{ /// <summary>
  /// UC4 : Ability to delete contact using name
  /// </summary>
    public class Program
    {   //An entrypoint of Console App
        static void Main(string[] args)
        {
            {
                List<Contact> addressBook = new List<Contact>(); //created list to store contacts
                int option;
                Console.WriteLine("\nWelcome to the Address book");
                do
                {
                    Console.WriteLine("\nEnter from the below options:");
                    Console.WriteLine("1. Add new contact");
                    Console.WriteLine("2. Display added contacts");
                    Console.WriteLine("3. Edit Existing Contact Using Name");
                    Console.WriteLine("4. Delete Contact Using Name");
                    Console.WriteLine("5. Exit");

                    option = Convert.ToInt32(Console.ReadLine());

                    //Loop to continue until user wants to exit
                    switch (option)
                    {
                        case 1:
                            addressBook.Add(Contact.AddContact());
                            break;
                        case 2:
                            Contact.DisplayContact(addressBook); 
                            break;
                        case 3:
                            Contact.EditContact(addressBook); 
                            break;
                        case 4:
                            Contact.DeleteContact(addressBook); 
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }


                } while (option != 4);

            }
        }
    }
}