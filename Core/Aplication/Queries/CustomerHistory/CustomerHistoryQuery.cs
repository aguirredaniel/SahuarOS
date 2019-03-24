namespace Core.Aplication.Queries.CustomerHistory
{
    public interface CustomerHistoryQuery
    {
        CustomerHistoryResult Execute(int customerId);
    }
}