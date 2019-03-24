using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Core.Domain.Order;
using URF.Core.Abstractions;

namespace Core.Aplication.Repositories
{
    public interface SahuarOSUnitOfWork : IUnitOfWork
    {
        OrderRepository OrderRepository { get; }
        CustomerRepository CustomerRepository { get; }
        ProductRepository ProductRepository { get; }
    }
}