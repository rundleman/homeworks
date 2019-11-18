using System.Collections.Generic;

namespace Example__05.HomeWork
{
    public class ChatDecoratorBase : IChat
    {
        protected readonly IChat Decoratee;

        protected ChatDecoratorBase(IChat chat)
        {
            Decoratee = chat;
        }

        public void SendMessage(Message message)
        {
            Decoratee.SendMessage(message);
        }

        public virtual List<Message> GetMessages()
        {
            return Decoratee.GetMessages();
        }
    }

    public class HidingUsersDecorator : ChatDecoratorBase
    {
        public HidingUsersDecorator(IChat chat) : base(chat) { }

        public override List<Message> GetMessages()
        {
            List<Message> newMessageQueue = new List<Message>();

            foreach (var message in Decoratee.GetMessages())
            {
                var newAuthor = message.GetAuthor().Length.ToString();
                var newRecipient = message.GetRecipient().Length.ToString();
                var newMessage = new Message(newAuthor, newRecipient, message.GetText());

                newMessageQueue.Add(newMessage);
            }

            return newMessageQueue;
        }
    }

    public class TextEncryptionDecorator : ChatDecoratorBase
    {
        public TextEncryptionDecorator(IChat chat) : base(chat) { }

        public override List<Message> GetMessages()
        {
            List<Message> newMessageQueue = new List<Message>();

            foreach (var message in Decoratee.GetMessages())
            {
                var cipherText = $"<Зашифровано> {message.GetText()} </Зашифровано>";

                var newMessage = new Message(message.GetAuthor(), message.GetRecipient(), cipherText);
                newMessageQueue.Add(newMessage);
            }

            return newMessageQueue;
        }
    }
}
