﻿using OrderServiceDesign.NotificationBase.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.SMSNotification.Strategy
{
    public class SMSSendStrategy : INotificationStrategy
    {
        public EnumNotificationType NotificationType => EnumNotificationType.SMS;
        private readonly ISMSSenderService _smsSenderService;

        public SMSSendStrategy(ISMSSenderService smsSenderService)
        {
            _smsSenderService = smsSenderService;
        }

        public async Task<bool> SendNotificationAsync(string recipient, string message)
        {
            // Implement your SMS notification logic here
            var result = await _smsSenderService.SendSMSAsync(recipient, message);
            return result;
        }
    }
}
