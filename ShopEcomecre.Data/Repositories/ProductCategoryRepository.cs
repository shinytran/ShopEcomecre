using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Data.Interfaces;
using ShopEcomecre.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopEcomecre.Data.Repositories
{
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.Dbcontext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}