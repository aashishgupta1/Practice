using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.SMSNotification.Strategy
{
    public class SMSSenderService : ISMSSenderService
    {
        public async Task<bool> SendSMSAsync(string recipient, string message)
        {
            return true;
        }
    }
}
