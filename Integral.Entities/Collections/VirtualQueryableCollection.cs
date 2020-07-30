using System;
using System.Linq;
using System.Linq.Expressions;

namespace Integral.Collections
{
    public abstract class VirtualQueryableCollection<Element> : VirtualEnumerableCollection<Element>, IQueryable<Element>
    {
        private readonly IQueryable<Element> queryable;

        protected VirtualQueryableCollection(IQueryable<Element> queryable) : base(queryable) => this.queryable = queryable;

        public Type ElementType => queryable.ElementType;

        public Expression Expression => queryable.Expression;

        public IQueryProvider Provider => queryable.Provider;
    }
}