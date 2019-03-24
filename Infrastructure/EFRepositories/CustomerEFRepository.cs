using Core.Aplication.Repositories;
using Core.SharedKernel;
using Microsoft.EntityFrameworkCore;
using URF.Core.EF;

namespace Infrastructure.EFRepositories
{
    public class CustomerEFRepository : Repository<Customer>, CustomerRepository
    {
        public CustomerEFRepository(DbContext context) : base(context)
        {
        }
    }
}