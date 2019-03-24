using System.Collections.Generic;
using System.Linq;
using Core.Aplication.Queries.ProductsByCategory;
using Infrastructure.Model;

namespace Infrastructure.EFQueries
{
    public class ProductsByCategoryEFQuery : ProductsByCategoryQuery
    {
        private readonly SahuarOSEFContext _context;

        public ProductsByCategoryEFQuery(SahuarOSEFContext context)
        {
            _context = context;
        }

        public IList<ProductsByCategoryResult> Execute(int categoryId)
        {
            return _context.Products.Where(product => product.Category.Id == categoryId)
                .Select(p => new ProductsByCategoryResult
                {
                    descripciton = p.Description,
                    id = p.Id,
                    name = p.Name,
                    sku = p.SKU
                }).ToList();
        }
    }
}