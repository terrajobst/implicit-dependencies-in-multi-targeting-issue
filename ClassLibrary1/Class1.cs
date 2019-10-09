using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1 : IAsyncDisposable
    {
        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
