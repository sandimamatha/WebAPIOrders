﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Core
{
    public interface IInventoryService
    {
       bool CheckInventory(string productId, int qty);
    }
}