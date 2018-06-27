using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Data.Interfaces;
using ShopEcomecre.Model.Models;

namespace ShopEcomecre.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="dbFactory"></param>
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}