namespace Core.Aplication.Queries.OrderDetails
{
    public interface OrderDetailsQuery
    {
        OrderDetailsResult Execute(int id);
    }
}