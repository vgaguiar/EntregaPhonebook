using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
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

        public Contact AddContact(string name)
        {
            Contact contact = new Contact(name);
            if (!this.persons.Contains(contact))
            {
                this.persons.Add(contact);
            }
            return contact;
        }

        public void RemoveContact(Contact contact)
        {
            if (this.persons.Contains(contact))
            {
                this.persons.Remove(contact);
            }
        }

        public void SendTo(List<Contact> contacts, string text, IMessageChannel channel)
        {
            Message message;

            foreach (Contact contact in contacts)
            {
                if (channel != null)
                {
                    message = channel.CreateMessage(this.Owner, contact);
                    message.Text = text;
                    channel.Send(message);
                }
            }
        }
         
        
        
    }
}