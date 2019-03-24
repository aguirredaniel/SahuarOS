using System;
using Core.Domain.Order;

namespace Core.Aplication.Queries.CustomerHistory
{
    public class OrderHistoryResult
    {
        public int id { get; set; }
        public DateTime lastModified { get; set; }
        public Order.OrderStatus status { get; set; }
    }
}