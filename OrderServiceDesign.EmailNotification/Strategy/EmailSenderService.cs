using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.EmailNotification.Strategy
{
    public class EmailSenderService : IEmailSenderService
    {
        public async Task<bool> SendEmailAsync(string recipient, string message)
        {
            return true;
        }
    }
}
