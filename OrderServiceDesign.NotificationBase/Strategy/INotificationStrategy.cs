using System.Threading.Tasks;

namespace OrderServiceDesign.NotificationBase.Strategy
{
    public interface INotificationStrategy
    {
        Task<bool> SendNotificationAsync(string recipient, string message);
        EnumNotificationType NotificationType { get; }
    }
}