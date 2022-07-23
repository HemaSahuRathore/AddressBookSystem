namespace AddressBookSystem
{ /// <summary>
  /// UC1 : Ability to create Contact in Address Book
  /// </summary>
    internal class Program
    {   //An entrypoint of Console App
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.ReadLine();

            Contact contact = new Contact(); //create contact by creating instance of Contact Class
            Console.WriteLine(contact.email);
        }
    }
}