using OrderServiceDesign.NotificationBase;

namespace OrderServiceDesign.SMSNotification
{
    public class SMSNotification : IAlertNotification
    {
        public string ToPhoneNumber {  get; set; }
        public void SendMessage(string receipt, string orderId)
        {
            // Send SMS Code here
        }
    }
}
