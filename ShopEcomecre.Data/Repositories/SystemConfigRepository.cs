using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Model.Models;

namespace ShopEcomecre.Data.Repositories
{
    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}