using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Order
    {
        public string ProductId;
        public int Qty;
        public Payment payment { get; set; }
    }
}