using System.Threading.Tasks;

namespace StrategyNotificationService.Interfaces
{
    public interface INotification
    {
        bool CanRun();
        Task Notify();
    }
}
