using System.Linq;
using Core.Aplication.Queries.OrderDetails;
using Infrastructure.Model;

namespace Infrastructure.EFQueries
{
    public class OrderDetailsEFQuery : OrderDetailsQuery
    {
        private readonly SahuarOSEFContext _context;

        public OrderDetailsEFQuery(SahuarOSEFContext context)
        {
            _context = context;
        }

        public OrderDetailsResult Execute(int id)
        {
            return _context.Orders.Where(order => order.Id == id)
                       .Select(o => new OrderDetailsResult
                       {
                           id = o.Id,
                           status = o.Status,
                           createdAt = o.CreatedAt,
                           products = o.Products.Select(p => new OrderProductDetailsResult()
                           {
                               descripciton = p.Product.Description,
                               id = p.Product.Id,
                               name = p.Product.Name,
                               sku = p.Product.SKU,
                               status = p.Status,
                           }).ToList()
                       }).FirstOrDefault() ??
                   new OrderDetailsResult();
        }
    }
}