using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Data.Interfaces;
using ShopEcomecre.Model.Models;

namespace ShopEcomecre.Data.Repositories
{
    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}