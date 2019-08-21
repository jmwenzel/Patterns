using StrategyNotificationService.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyNotificationService.Implementations
{
    public class NotificationService : INotificationService
    {
        private readonly IEnumerable<INotification> _notifications;

        public NotificationService(IEnumerable<INotification> notifications)
        {
            _notifications = notifications;
        }
        public async Task Notify()
        {
            _notifications.Where(x => x.CanRun()).ToList().Select(x => x.Notify());
            await Task.WhenAll(_notifications.Where(x => x.CanRun()).ToList().Select(x => x.Notify())); 
        }
    }
}
