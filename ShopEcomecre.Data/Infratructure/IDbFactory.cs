using System;

namespace ShopEcomecre.Data.Infratructure
{
    public interface IDbFactory : IDisposable
    {
        EcomecreDbContext Init();
    }
}