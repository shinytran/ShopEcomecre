using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Data.Interfaces;
using ShopEcomecre.Model.Models;

namespace ShopEcomecre.Data.Repositories
{
    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="dbFactory"></param>
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}