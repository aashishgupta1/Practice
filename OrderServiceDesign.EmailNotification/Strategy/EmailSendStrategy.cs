using OrderServiceDesign.NotificationBase.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.EmailNotification.Strategy
{
    public class EmailSendStrategy : INotificationStrategy
    {
        public EnumNotificationType NotificationType => EnumNotificationType.Email;
        private readonly IEmailSenderService _emailSenderService;

        public EmailSendStrategy(IEmailSenderService emailSenderService)
        {
            _emailSenderService = emailSenderService;
        }

        public async Task<bool> SendNotificationAsync(string recipient, string message)
        {
            // Implement your email notification logic here
            var result = await _emailSenderService.SendEmailAsync(recipient, message);
            return result;
        }
    }
}
