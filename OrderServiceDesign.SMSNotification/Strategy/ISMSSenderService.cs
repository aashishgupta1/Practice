using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.SMSNotification.Strategy
{
    public interface ISMSSenderService
    {
        Task<bool> SendSMSAsync(string recipient,string message);
    }
}
