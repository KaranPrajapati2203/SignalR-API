using Microsoft.AspNetCore.SignalR;


namespace SignalR_Demo_API
{
    public class ChatHub : Hub
    {
        private readonly MessageStorageService _messageStorageService;

        public ChatHub(MessageStorageService messageStorageService)
        {
            _messageStorageService = messageStorageService;
        }

        public async Task SendMessage(string user, string message)
        {
            var chatMessage = new ChatMessage
            {
                User = user,
                Message = message,
                Timestamp = DateTime.UtcNow
            };

            _messageStorageService.AddMessage(chatMessage);

            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }

    public class ChatMessage
    {
        public string User { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
