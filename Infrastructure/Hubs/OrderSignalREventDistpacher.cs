using System.Linq;
using Core.Aplication.UseCases.NewOrder;
using Core.Domain.Order;
using Microsoft.AspNetCore.SignalR;

namespace Infrastructure.Hubs
{
    public class OrderSignalREventDistpacher : NewOrderEventDistpacher
    {
        private readonly IHubContext<OrderHub> _hubContext;

        public OrderSignalREventDistpacher(IHubContext<OrderHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public void Distpach(Order order)
        {
            _hubContext.Clients.All.SendAsync("newOrder", new
            {
                id = order.Id,
                customer = order.Customer.Name,
                products = order.Products.Select(product => new
                {
                    id = product.Product.Id,
                    name = product.Product.Name
                }),
                progress = order.FinishedPercentage(),
                creatAt = order.CreatedAt.ToString("MM/dd/yyyy H:mm"),
                status = order.Status
            });
        }
    }
}