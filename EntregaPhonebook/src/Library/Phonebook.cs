using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(string name, string phone, string id)
        {
            this.Owner = CreateContact(name, phone, id);
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }

        public void AddContact(string name, string phone, string id)
        {
            Contact contact = CreateContact(name, phone,  id);
            if (!this.persons.Contains(contact))
            {
                this.persons.Add(contact);
            }
        }

        public void RemoveContact(Contact contact)
        {
            if (this.persons.Contains(contact))
            {
                this.persons.Remove(contact);
            }
        }

         public void SendWhatsApp(string[] names, string text)
        {
            IMessageChannel messageChannel = new WhatsAppChannel();
            foreach (Contact contact in this.persons)
            {
                foreach (string name in names)
                {
                    if (contact.Name.Equals(name))
                    {
                        Message message = new WhatsAppMessage(this.Owner.Phone, contact.Phone , text);
                        messageChannel.Send(message);
                    }
                }
            }
        }

        public void SendTwitter(string[] names, string text)
        {
            IMessageChannel messageChannel = new TwitterChannel();
            foreach (Contact contact in this.persons)
            {
                foreach (string name in names)
                {
                    if (contact.Name.Equals(name))
                    {
                        Message message = new twitterMessage(this.Owner.Id, contact.Id , text);
                        messageChannel.Send(message);
                    }
                }
            }
        }
        
        private Contact CreateContact(string name, string phone, string id)
        {
            return new Contact(name, phone, id);
        }
    }
}