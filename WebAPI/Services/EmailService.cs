using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Core;

namespace WebAPI.Services
{
    public class EmailService :IEmailService
    {
        public bool SendEmail(string toAddress, string subject)
        {
            return true;
        }

    }
}