using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Core;

namespace WebAPI.Services
{
    public class InventoryService : IInventoryService
    {

        public bool CheckInventory(string productId, int qty)
        {
            return true;
        }
    }
}