using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Core;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly IOrderService _orderService;

        public OrdersController()
        {
            _orderService = new OrderService();
        }

        public HttpResponseMessage Post([FromBody]Order order)
        {
            try
            {
                _orderService.Order(order);
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotImplemented, "Sorry, we couldn't place your order");
            }
            return Request.CreateResponse(HttpStatusCode.OK, order);
        }
       
    }
}
