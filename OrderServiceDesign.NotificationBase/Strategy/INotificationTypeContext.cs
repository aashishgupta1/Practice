namespace OrderServiceDesign.NotificationBase.Strategy
{
    public interface INotificationTypeContext
    {
        INotificationStrategy GetNotificationTypeStrategy(EnumNotificationType notificationType);
    }
}