using System;

namespace Library
{
    public class twitterMessage : Message
    {
        public twitterMessage(string from, string to, string text) : base (from, to, text)
        {
            this.From = "UCU";
        }
    }
}