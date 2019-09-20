using System;

namespace Library

{
    public class TwitterChannel : IMessageChannel
    {
        string consumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
        string consumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
        string accessTokenSecret = "eAut3eKlWwBB0o1BfTRLaRBfOgXF6WriMKwpkevgf7C2t";
        string accessToken = "1396065818-9Q6o38qm99WQywFeqrJFTfs7DFAhI4LvjoJvFRk";

        public TwitterChannel()
        {
        }
        public void Send(Message message)
        {
            var twitterDirectMessage = new TwitterMessage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitterDirectMessage.SendMessage(message.Text, message.To));
        }
    }
}