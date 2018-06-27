using ShopEcomecre.Model.Models;
using System.Collections.Generic;

namespace ShopEcomecre.Data.Interfaces
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
}