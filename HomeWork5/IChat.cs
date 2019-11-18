using System.Collections.Generic;

namespace Example__05.HomeWork
{
    public interface IChat
    {
        void SendMessage(Message message);
        List<Message> GetMessages();
    }
}
