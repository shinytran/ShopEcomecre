using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Model.Models;
using System.Collections.Generic;

namespace ShopEcomecre.Data.Interfaces
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
}