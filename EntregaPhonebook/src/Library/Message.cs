namespace Library
{
    public abstract class Message
    {
        protected Message(string from, string to, string text)
        {
            this.From = from;
            this.To = to;
            this.Text = text;
        }

        public string Text { get; set; }

        public string From { get; set; }

        public string To { get; }
    }
}