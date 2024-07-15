using SignalR_Demo_API;

public class MessageStorageService
{
    private readonly List<ChatMessage> _messages = new List<ChatMessage>();

    public void AddMessage(ChatMessage message)
    {
        _messages.Add(message);
    }

    public List<ChatMessage> GetMessages()
    {
        return _messages;
    }
}
