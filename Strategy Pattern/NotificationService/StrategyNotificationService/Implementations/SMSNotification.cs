using StrategyNotificationService.Interfaces;
using System.Diagnostics;
using System.Threading.Tasks;

namespace StrategyNotificationService.Implementations
{
    public class SMSNotification : INotification
    {
        public bool CanRun()
        {
            return false;
        }

        public async Task Notify()
        {
            await Task.Run(() => Debug.WriteLine("Send SMS notification"));
        }
    }
}
