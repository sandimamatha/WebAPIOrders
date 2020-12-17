using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Core;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class OrderService
    {
        private readonly IInventoryService _iinventoryService;
        private readonly IPaymentService _ipaymentService;
        private readonly IEmailService _iemailService;

        public OrderService(IInventoryService _iinventoryService, IPaymentService _ipaymentService)
        {
           
        }
        public void Order(Order order)
        {
            bool isProductAvailable;
            bool isCharged;
            isProductAvailable = _iinventoryService.CheckInventory(order.ProductId, order.Qty);

            if (isProductAvailable)
            {
                isCharged = _ipaymentService.ChargePayment(order.payment.CreditCardNumber, order.payment.Amount);

                if (isCharged)
                {
                    _iemailService.SendEmail("sandimamatha@gmail.com", "Please place this order");
                }
            }
        }
    }
}