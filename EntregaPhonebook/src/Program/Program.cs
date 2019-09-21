using System;
using Library;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact owner = new Contact("Federico");
            Phonebook phonebook = new Phonebook(owner);
            Contact contact1 = phonebook.AddContact("Patricio");
            contact1.Phone= "+59891409412";
            contact1.Twitter= "73234797";
            Contact contact2 = phonebook.AddContact("Valentina");
            contact2.Phone= "+59894877936";
            contact2.Twitter= "1111111111";
            string[] names = {"Patricio", "Valentina"};
            List<Contact> contacts = phonebook.Search(names);
            IMessageChannel channel = new TwitterChannel();
            phonebook.SendTo(contacts, "Message was sent!", channel);
            channel = new WhatsAppChannel();
            phonebook.SendTo(contacts, "Message was sent!", channel);
        }
    }
}
