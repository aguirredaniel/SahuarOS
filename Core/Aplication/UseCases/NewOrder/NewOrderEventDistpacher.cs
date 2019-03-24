using Core.Domain.Order;

namespace Core.Aplication.UseCases.NewOrder
{
    public interface NewOrderEventDistpacher
    {
         void Distpach(Order order);
    }
}