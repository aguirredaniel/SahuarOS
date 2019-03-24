using System;

namespace Core.Domain.Order
{
    public class OrderProduct
    {
        public enum OrderProductStatus
        {
            Received,
            Started,
            Finished,
        }


        public int Id { get; protected set; }
        public int Amount { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime LastModified { get; protected set; }
        public OrderProductStatus Status { get; protected set; }
        public virtual Product Product { get; protected set; }

        protected OrderProduct()
        {
        }


        public byte[] Start(DateTime now)
        {
            Status = OrderProductStatus.Started;
            LastModified = now;

            return Product.GCode;
        }

        public void Finish(DateTime now)
        {
            Status = OrderProductStatus.Finished;
            LastModified = now;
        }

        public int IncreaseAmount(int amount)
        {
            return Amount += amount;
        }


        public static OrderProduct Create(Product product, DateTime createdAt)
        {
            return new OrderProduct {Product = product, CreatedAt = createdAt, LastModified = createdAt};
        }
    }
}