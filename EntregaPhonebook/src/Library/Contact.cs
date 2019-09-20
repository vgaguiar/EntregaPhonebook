namespace Library
{
    public class Contact
    {
        public Contact(string name, string phone,  string id)
        {
            this.Name = name;
            this.Phone = phone;
            this.Id = id;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Id { get; set; }
    }
}