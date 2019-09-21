using System;
using TwitterUCU;

namespace Library

{
    public class TwitterChannel : IMessageChannel
    {
        private const string consumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
        private const string consumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
        private const string accessTokenSecret = "eAut3eKlWwBB0o1BfTRLaRBfOgXF6WriMKwpkevgf7C2t";
        private const string accessToken = "1396065818-9Q6o38qm99WQywFeqrJFTfs7DFAhI4LvjoJvFRk";
        private TwitterUCU.TwitterMessage twitterApi= new TwitterMessage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
        public Message CreateMessage(Contact from, Contact to)
        {
            return new twitterMessage(from.Name, to.Twitter);
        }
        public void Send(Message message)
        {
            this.twitterApi.SendMessage(message.Text, message.To);
        }
    }
}