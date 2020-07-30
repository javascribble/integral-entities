using System.Collections;
using System.Collections.Generic;

namespace Integral.Collections
{
    public abstract class VirtualEnumerableCollection<Element> : IEnumerable<Element>
    {
        private readonly IEnumerable<Element> enumerable;

        protected VirtualEnumerableCollection(IEnumerable<Element> enumerable) => this.enumerable = enumerable;

        public IEnumerator<Element> GetEnumerator() => enumerable.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}