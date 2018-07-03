using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Data.Interfaces;
using ShopEcomecre.Model.Models;

namespace ShopEcomecre.Data.Repositories
{
    public class PostTagRepository : RepositoryBase<ProductCategory>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}