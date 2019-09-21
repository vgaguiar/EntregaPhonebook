using System;

namespace WhatsAppApiUCU
{
    class Program 
    {
        static void Main(string[] args)
        { 
            const string accountSid = "ACa8395e7223e7719988c09db8dfb68f0f";
            const string authToken = "fdcaac12dc7e5b031908429ee402e7a4";

            var whatsApp = new WhatsAppApi(accountSid, authToken);
            string sid = whatsApp.Send("+598<Poné tu teléfono acá>", "Hey there! I'm using WhatsAppUCU");
            Console.WriteLine(sid);
        }
    }
}
