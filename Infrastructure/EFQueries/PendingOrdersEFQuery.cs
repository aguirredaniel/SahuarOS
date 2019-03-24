using System.Collections.Generic;
using System.Linq;
using Core.Aplication.Queries.PendingOrders;
using Core.Domain.Order;
using Infrastructure.Model;

namespace Infrastructure.EFQueries
{
    public class PendingOrdersEFQuery : PendingOrdersQuery
    {
        private readonly SahuarOSEFContext _context;

        public PendingOrdersEFQuery(SahuarOSEFContext context)
        {
            _context = context;
        }

        public IList<PendingOrdersResult> Execute()
        {
            return _context.Orders.Where(order => order.Status != Order.OrderStatus.Finished)
                .Select(order => new PendingOrdersResult
                {
                    createdAt = order.CreatedAt,
                    customer = order.Customer.Name,
                    lastModified = order.LastModified,
                    orderId = order.Id
                }).ToList();
        }
    }
}