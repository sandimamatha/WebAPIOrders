using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Core;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly IOrderService _iorderService;

        public OrdersController(IOrderService _iorderService)
        {
           
        }
        public void Post([FromBody]Order order)
        {
            _iorderService.Order(order);
        }
       
    }
}
