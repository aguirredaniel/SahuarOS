using System.Collections.Generic;

namespace Core.Aplication.Queries.ProductsByCategory
{
    public interface ProductsByCategoryQuery
    {
        IList<ProductsByCategoryResult> Execute(int categoryId);
    }
}