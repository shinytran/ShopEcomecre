using ShopEcomecre.Data.Infratructure;

namespace ShopEcomecre.Data.Repositories
{
    public class TagRepository : RepositoryBase<TagRepository>, ITagRepository
    {
        protected TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}