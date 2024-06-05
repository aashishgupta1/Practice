using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.EmailNotification.Strategy
{
    public interface IEmailSenderService
    {
        Task<bool> SendEmailAsync(string recipient, string message);
    }
}
