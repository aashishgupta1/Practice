using System.Collections.Generic;
using System.Linq;

namespace OrderServiceDesign.NotificationBase.Strategy
{

    public class NotificationTypeContext : INotificationTypeContext
    {
        private readonly IEnumerable<INotificationStrategy> _notificationStrategies;

        public NotificationTypeContext(IEnumerable<INotificationStrategy> notificationStrategies)
        {
            _notificationStrategies = notificationStrategies;
        }

        public INotificationStrategy GetNotificationTypeStrategy(EnumNotificationType notificationType)
        {
            var notificationTypeStrategy = _notificationStrategies.FirstOrDefault(t => t.NotificationType == notificationType);
            return notificationTypeStrategy;
        }
    }
}
