
namespace Library
{
    public interface IMessageChannel
    {
        Message CreateMessage(Contact from, Contact to);
        void Send(Message message);
    }
}