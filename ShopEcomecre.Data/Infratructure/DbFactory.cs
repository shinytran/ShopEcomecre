using System;

namespace ShopEcomecre.Data.Infratructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private EcomecreDbContext dbContext;

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
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}