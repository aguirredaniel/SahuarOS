namespace Core.Domain.Order
{
    public class ProductCategory
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }

        protected ProductCategory()
        {
        }
    }
}