using StrategyNotificationService.Interfaces;
using System.Diagnostics;
using System.Threading.Tasks;

namespace StrategyNotificationService.Implementations
{
    public class WhatsAppNotification : INotification
    {
        public bool CanRun()
        {
            return true;
        }

        public async Task Notify()
        {
            await Task.Run(() => Debug.WriteLine("Send WhatsApp notification"));
        }
    }
}
