using System;
using Core.Domain.Order;

namespace Core.Aplication.Queries.PendingOrders
{
    public class PendingOrdersResult
    {
        public int orderId { get; set; }
        public string customer { get; set; }
        public Order.OrderStatus status { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime lastModified { get; set; }
    }
}