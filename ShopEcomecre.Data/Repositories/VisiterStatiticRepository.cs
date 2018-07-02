using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Model.Models;

namespace ShopEcomecre.Data.Repositories
{
    public class VisiterStatiticRepository : RepositoryBase<VisiterStatitic>, IVisiterStatiticRepository
    {
        public VisiterStatiticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}