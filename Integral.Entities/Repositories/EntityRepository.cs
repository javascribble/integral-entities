using Integral.Providers;
using Microsoft.EntityFrameworkCore;

namespace Integral.Repositories
{
    public abstract class EntityRepository<Entity> : EntityProvider<Entity>, Repository<Entity>
        where Entity : class
    {
        private readonly DbSet<Entity> dbSet;

        protected EntityRepository(DbSet<Entity> dbSet) : base(dbSet) => this.dbSet = dbSet;

        public virtual bool Add(Entity entity)
        {
            dbSet.Add(entity);
            return true;
        }

        public virtual bool Remove(Entity entity)
        {
            dbSet.Remove(entity);
            return true;
        }
    }
}
