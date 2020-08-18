using Integral.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Integral.Facades
{
    public abstract class EntityFacade : Executable, Disposable
    {
        private readonly DbContext dbContext;

        protected EntityFacade(DbContext dbContext) => this.dbContext = dbContext;

        public virtual void Execute() => dbContext.SaveChanges();

        public virtual void Dispose() => dbContext.Dispose();
    }
}