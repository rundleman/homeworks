using System.Collections.Generic;

namespace Example__05.HomeWork
{
    public class Chat : IChat
    {
        private List<Message> _messageQueue = new List<Message>();

        public void SendMessage(Message message)
        {
            _messageQueue.Add(message);
        }

        public List<Message> GetMessages()
        {
            return _messageQueue;
        }
    }
}
