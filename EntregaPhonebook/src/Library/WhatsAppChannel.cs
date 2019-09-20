using System;

namespace Library
{
    public class WhatsAppChannel :IMessageChannel

    {
        string accountSid = "ACa8395e7223e7719988c09db8dfb68f0f";
        string authToken = "fdcaac12dc7e5b031908429ee402e7a4";
        public WhatsAppChannel()
        {         
        }
        public void Send(Message message)
        {
            var whatsApp = new WhatsAppApi(accountSid, authToken);
            string sid = whatsApp.Send(message.To, message.Text);
            Console.WriteLine(sid);
        }
    }
}