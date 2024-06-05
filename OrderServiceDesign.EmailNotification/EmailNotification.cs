using OrderServiceDesign.NotificationBase;

namespace OrderServiceDesign.EmailNotification
{
    public class EmailNotification : IAlertNotification
    {
        public string ToEmailAddress {  get; set; }
        public void SendMessage(string receipt, string orderId)
        {
            // Send Email Code Here
        }
    }
}
