using System;
using System.Collections.Generic;
using Core.Domain.Order;

namespace Core.Aplication.Queries.OrderDetails
{
    public class OrderDetailsResult
    {
        public int id { get; set; }
        public Order.OrderStatus status { get; set; }
        public DateTime createdAt { get; set; }
        public IList<OrderProductDetailsResult> products;
    }
}