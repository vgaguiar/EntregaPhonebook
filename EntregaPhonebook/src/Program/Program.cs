using System;
using Library;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            string UcuChannel = "+14155238886";

            Phonebook phonebook = new Phonebook("TwitterUcu", UcuChannel, "UCU");

           
            phonebook.AddContact("Patricio", "+59891409412", "73234797");
            phonebook.AddContact("Valentina", "+59894877936", "1111111111");
            string[] names = {"Patricio", "Valentina"};
            List<Contact> contacts = phonebook.Search(names);  
            phonebook.SendWhatsApp(names, "Message!");
            phonebook.SendTwitter(names, "Message!");
        }
    }
}
