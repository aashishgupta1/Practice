using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.NotificationBase
{
    public interface IAlertNotification
    {
        void SendMessage(string receipt, string orderId);
    }
}
