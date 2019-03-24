using System;

namespace Core.Domain.Order
{
    public class Product
    {
        public int Id { get; protected set; }
        public string SKU { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public decimal Price { get; protected set; }
        public byte[] Image { get; set; }
        public byte[] GCode { get; set; }

        
        public virtual ProductCategory Category { get; protected set; }

        protected Product()
        {
        }

    }
}