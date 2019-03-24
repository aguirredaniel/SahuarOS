using System.Collections.Generic;

namespace Core.Aplication.Queries.PendingOrders
{
    public interface PendingOrdersQuery
    {
        IList<PendingOrdersResult> Execute();
    }
}