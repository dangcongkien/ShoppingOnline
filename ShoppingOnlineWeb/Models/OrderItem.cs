﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingOnlineWeb.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }

        // Navigation properties
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
