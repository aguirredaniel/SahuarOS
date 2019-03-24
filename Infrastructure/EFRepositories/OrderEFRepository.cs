using Core.Aplication.Repositories;
using Core.Domain.Order;
using Microsoft.EntityFrameworkCore;
using URF.Core.EF;

namespace Infrastructure.EFRepositories
{
    public class OrderEFRepository : Repository<Order>, OrderRepository
    {
        public OrderEFRepository(DbContext context) : base(context)
        {
        }
    }
}