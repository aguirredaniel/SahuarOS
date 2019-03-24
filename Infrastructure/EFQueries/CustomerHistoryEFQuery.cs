using System.Linq;
using Core.Aplication.Queries.CustomerHistory;
using Infrastructure.Model;

namespace Infrastructure.EFQueries
{
    public class CustomerHistoryEFQuery : CustomerHistoryQuery
    {
        private readonly SahuarOSEFContext _context;

        public CustomerHistoryEFQuery(SahuarOSEFContext context)
        {
            _context = context;
        }

        public CustomerHistoryResult Execute(int customerId)
        {
            return _context.Customers.Where(customer => customer.Id == customerId)
                       .Select(c => new CustomerHistoryResult
                       {
                           orders = _context.Orders.Where(o => o.Customer.Id == customerId)
                               .Select(o => new OrderHistoryResult
                               {
                                   id = o.Id,
                                   lastModified = o.LastModified,
                                   status = o.Status
                               }).ToList()
                       }).FirstOrDefault() ?? new CustomerHistoryResult();
        }
    }
}