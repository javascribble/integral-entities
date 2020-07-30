using Integral.Contexts;
using Integral.Abstractions;

namespace Integral.Facades
{
    public abstract class EntityFacade : Executable, Disposable
    {
        private readonly EntityContext entityContext;

        protected EntityFacade(EntityContext entityContext) => this.entityContext = entityContext;

        public virtual void Execute() => entityContext.SaveChanges();

        public virtual void Dispose() => entityContext.Dispose();
    }
}