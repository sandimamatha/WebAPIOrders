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
        private readonly IInventoryService _inventoryService;
        private readonly IPaymentService _paymentService;
        private readonly IEmailService _emailService;

        public OrderService(IInventoryService inventoryService, IPaymentService paymentService, IEmailService emailService)
        {
            _inventoryService = inventoryService;
            _paymentService = paymentService;
            _emailService  = emailService;
        }
        public void Order(Order order)
        {
            bool isProductAvailable;
            bool isCharged;
            isProductAvailable = _inventoryService.CheckInventory(order.ProductId, order.Qty);

            if (isProductAvailable)
            {
                Payment payment = new Payment();
                payment.CreditCardNumber = "1234123412341234";
                payment.Amount = 12;
                isCharged = _paymentService.ChargePayment(payment.CreditCardNumber, payment.Amount);

                if (isCharged)
                {
                    _emailService.SendEmail("sandimamatha@gmail.com", "Please place this order");
                }
            }
        }
    }
}