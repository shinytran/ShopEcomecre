using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopEcomecre.Data.Infratructure
{
   public class DbFactory : Disposable, IDbFactory
    {
        EcomecreDbContext dbContext;
        public EcomecreDbContext Init()
        {
            try
            {
                return dbContext ?? (dbContext = new EcomecreDbContext());
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }
        protected override void DisposeCore()
        {
            if (dbContext!=null)
            {
                dbContext.Dispose();
            }
           
        }
    }
}
