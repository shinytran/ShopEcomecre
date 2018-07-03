using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Model.Models;

namespace ShopEcomecre.Data.Repositories
{
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        protected TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}