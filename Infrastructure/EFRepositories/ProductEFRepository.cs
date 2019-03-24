using Core.Aplication.Repositories;
using Core.Domain.Order;
using Microsoft.EntityFrameworkCore;
using URF.Core.EF;

namespace Infrastructure.EFRepositories
{
    public class ProductEFRepository : Repository<Product>, ProductRepository
    {
        public ProductEFRepository(DbContext context) : base(context)
        {
        }
    }
}