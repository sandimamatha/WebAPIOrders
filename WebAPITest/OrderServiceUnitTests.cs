using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPITest
{
    [TestClass]
    public class OrderServiceUnitTests
    {
        private OrderService _orderService;
        private Mock<IInventoryService> _mockInventoryService;
        private Mock<IPaymentService> _mockPaymentService;
        private Mock<IEmailService> _mockEmailService;
        [TestInitialize]
        public void TestInitialize()
        {
            //mock the dependencies
            _mockInventoryService = new Mock<IInventoryService>();
            _mockPaymentService = new Mock<IPaymentService>();
            _mockEmailService = new Mock<IEmailService>();
        }
        [TestMethod]
        public void OrderServiceUnitTests_Order_SuccessfulOrder()
        {
            try
            {
                //arrange
                Order order = new Order { ProductId = "1234", Qty = 2 };


                _mockInventoryService.Setup(r => r.CheckInventory(order.ProductId, order.Qty)).Returns(true);

                Payment payment = new Payment { CreditCardNumber = "1234123412341234", Amount = 12 };
                _mockPaymentService.Setup(r => r.ChargePayment(payment.CreditCardNumber, payment.Amount)).Returns(true);

                _mockEmailService.Setup(r => r.SendEmail("sandimamatha@gmail.com", "Please place this order"));

                //act
                _orderService = new OrderService();

                _orderService.Order(order);

                //assert
                //indicates success
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
