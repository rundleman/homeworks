namespace Example__05.HomeWork
{
    public class Message
    {
        private string _author;
        private string _recipient;
        private string _text;

        public Message(string author, string recipient, string text)
        {
            _author = author;
            _recipient = recipient;
            _text = text;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public string GetRecipient()
        {
            return _recipient;
        }

        public string GetText()
        {
            return _text;
        }
    }
}
