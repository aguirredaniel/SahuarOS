using Core.Aplication.Repositories;
using Microsoft.EntityFrameworkCore;
using URF.Core.EF;

namespace Infrastructure.EFRepositories
{
    public class SahuarOSEFUnitOfWork : UnitOfWork, SahuarOSUnitOfWork
    {
        public SahuarOSEFUnitOfWork(DbContext context) : base(context)
        {
        }

        public OrderRepository OrderRepository => new OrderEFRepository(Context);
        public CustomerRepository CustomerRepository => new CustomerEFRepository(Context);
        public ProductRepository ProductRepository => new ProductEFRepository(Context);
    }
}