using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Model.Models;

namespace ShopEcomecre.Data.Repositories
{
    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}