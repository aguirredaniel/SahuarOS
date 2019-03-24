using Core.Domain.Order;

namespace Core.Aplication.Queries.OrderDetails
{
    public class OrderProductDetailsResult : ProductDetails
    {
        public OrderProduct.OrderProductStatus status { get; set; }
    }
}