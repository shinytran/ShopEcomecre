using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Model.Models;

namespace ShopEcomecre.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}