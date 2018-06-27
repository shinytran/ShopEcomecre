using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Data.Interfaces;
using ShopEcomecre.Model.Models;

namespace ShopEcomecre.Data.Repositories
{
    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}