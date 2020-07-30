using System.Collections.Generic;

namespace Integral.Providers
{
    public interface Provider<Provision> : IEnumerable<Provision>
    {
        bool Find(object identity, out Provision provision);
    }
}