using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Core
{
    public interface IOrderService
    {
        void Order(Order order);
    }
}