using AddressBookSys.AddressBookSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSys
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");

            AddressBook newaddress = new AddressBook();
            newaddress.ContactDetails();
        }
    }
}