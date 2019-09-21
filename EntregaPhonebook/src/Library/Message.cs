namespace Library
{
    public abstract class Message
    {
        protected Message(string from, string to)
        {
            this.From = from;
            this.To = to;
        }

        public string Text { get; set; }

        public string From { get; set; }

        public string To { get; }
    }
}