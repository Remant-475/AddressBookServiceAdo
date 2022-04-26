
using System;

namespace AdressBookServiceAdo.net
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Address Book System Ado.Net");
            ContactDetails details = new ContactDetails();
            details.EstablishConnection();
            details.CloseConnection();
        }
    }
}
