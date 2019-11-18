using System;

namespace Example__05.HomeWork
{
    public class Test
    {
        public static void Main(string[] args)
        {
            var message1 = new Message("Дима", "Маша", "Привет!");
            var message2 = new Message("Дима", "Маша", "Как дела?");
            var message3 = new Message("Маша", "Дима", "Хорошо. А у тебя?");
            var message4 = new Message("Дима", "Маша", "Нормально");
            
            IChat chat = new Chat();

            chat.SendMessage(message1);
            chat.SendMessage(message2);
            chat.SendMessage(message3);
            chat.SendMessage(message4);

            //chat = new HidingUsersDecorator(chat);
            //chat = new TextEncryptionDecorator(chat);

            chat = new ChatBuilder(chat).WithHidingUsers().WithTextEncryption().Build();

            foreach (var message in chat.GetMessages())
            {
                Console.WriteLine(message.GetAuthor() + message.GetRecipient() + message.GetText());
            }

            Console.ReadKey();
        }
    }
}
