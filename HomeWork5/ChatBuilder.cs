namespace Example__05.HomeWork
{
    public class ChatBuilder
    {
        private IChat _chat;

        public ChatBuilder(IChat chat)
        {
            _chat = chat;
        }

        public ChatBuilder WithHidingUsers()
        {
            _chat = new HidingUsersDecorator(_chat);
            return this;
        }

        public ChatBuilder WithTextEncryption()
        {
            _chat = new TextEncryptionDecorator(_chat);
            return this;
        }

        public IChat Build()
        {
            return _chat;
        }
    }
}
