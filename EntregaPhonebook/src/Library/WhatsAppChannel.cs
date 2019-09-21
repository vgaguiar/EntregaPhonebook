using System;
using WhatsAppApiUCU;

namespace Library
{
    public class WhatsAppChannel :IMessageChannel

    {
        private const string accountSid = "ACa8395e7223e7719988c09db8dfb68f0f";
        private const string authToken = "fdcaac12dc7e5b031908429ee402e7a4";
        private WhatsAppApiUCU.WhatsAppApi whatsappApi = new WhatsAppApi(accountSid, authToken);
        public Message CreateMessage(Contact from, Contact to)
        {
            return new WhatsAppMessage(WhatsAppChannel.accountSid, to.Phone);
        }
        public void Send(Message message)
        {
            this.whatsappApi.Send(message.To, message.Text);
        }
    }
}