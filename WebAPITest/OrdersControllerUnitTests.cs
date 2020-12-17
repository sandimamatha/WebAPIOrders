using System;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebAPI.Controllers;
using WebAPI.Core;
using WebAPI.Models;

namespace WebAPITest
{
    [TestClass]
    public class OrdersControllerUnitTests
    {
        private OrdersController _controller;
        private Mock<IOrderService> _mockOrderService;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockOrderService = new Mock<IOrderService>();
        }

        [TestMethod]
        public void OrdersControllerUnitestTest_Post_SuccessfullOrder_ShouldReturnOk()
        {

            //arrange
            Order order = new Order { ProductId = "123", Qty = 2 };
            _mockOrderService.Setup(r => r.Order(order));

            //act
            _controller = new OrdersController();
            _controller.Request = new HttpRequestMessage();
            _controller.Configuration = new HttpConfiguration();

            var result = _controller.Post(order);

            //assert
            Assert.AreEqual("123", order.ProductId);
        }

    }
}
