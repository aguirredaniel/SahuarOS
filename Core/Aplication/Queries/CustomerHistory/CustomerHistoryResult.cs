using System.Collections.Generic;

namespace Core.Aplication.Queries.CustomerHistory
{
    public class CustomerHistoryResult
    {
       public IList<OrderHistoryResult> orders { get; set; }
    }
}