﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeDuShopData.Infrrastructure
{
    public class Disposeable : IDisposable
    {
        private bool isDisposed;
        ~Disposeable()
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
            if(!isDisposed && disposing)
            {
                DisposeCore();
            }
        }
        protected virtual void DisposeCore()
        {

        }
    }
}
