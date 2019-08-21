using Microsoft.AspNetCore.Mvc;
using StrategyNotificationService.Interfaces;
using System.Threading.Tasks;

namespace WebNotification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        // GET api/notification
        [HttpGet]
        public async Task<IActionResult> BroadCastNotification()
        {
            await _notificationService.Notify();
            return Ok("Notifications sent");
        }
    }
}