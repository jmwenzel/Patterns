using StrategyNotificationService.Interfaces;
using System.Diagnostics;
using System.Threading.Tasks;

namespace StrategyNotificationService.Implementations
{
    public class EmailNotification : INotification
    {
        public bool CanRun()
        {
            return true;
        }

        public async Task Notify()
        {
            await Task.Run(() => Debug.WriteLine("Send Email notification..."));
        }
    }
}
