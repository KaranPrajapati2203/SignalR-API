using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalR_Demo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly MessageStorageService _messageStorageService;

        public ChatController(MessageStorageService messageStorageService)
        {
            _messageStorageService = messageStorageService;
        }

        [HttpGet("messages")]
        public ActionResult<List<ChatMessage>> GetMessages()
        {
            return _messageStorageService.GetMessages();
        }
    }
}
