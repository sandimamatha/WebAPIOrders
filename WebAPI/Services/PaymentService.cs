using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Core;

namespace WebAPI.Services
{
    public class PaymentService: IPaymentService
    {
        public bool ChargePayment(string creditCardNumber, decimal amount)
        {
            return true;
        }
    }
}