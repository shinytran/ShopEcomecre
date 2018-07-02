using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Model.Models;

namespace ShopEcomecre.Data.Repositories
{
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}