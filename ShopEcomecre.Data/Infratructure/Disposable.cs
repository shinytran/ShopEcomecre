using System;

namespace ShopEcomecre.Data.Infratructure
{
    public class Disposable : IDisposable
    {
        #region IDisposable Support

        private bool isDisposed; // To detect redundant calls

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        protected virtual void DisposeCore()
        {
            throw new NotImplementedException();
        }

        #endregion IDisposable Support
    }
}