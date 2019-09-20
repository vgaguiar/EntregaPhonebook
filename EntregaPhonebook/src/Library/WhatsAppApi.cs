using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Library
{
    public class WhatsAppApi
    {
        private string accountSid;
        private string authToken;

        public WhatsAppApi(string accountSid, string authToken)
        {
            this.accountSid = accountSid;
            this.authToken = authToken;
        }

        public string Send(string to, string text)
        {
            TwilioClient.Init(this.accountSid, this.authToken);

            var message = MessageResource.Create(
                body: text,
                from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
                to: new Twilio.Types.PhoneNumber($"whatsapp:{to}")
            );

            return message.Sid;
        }
    }
}