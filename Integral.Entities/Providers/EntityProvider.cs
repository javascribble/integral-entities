using Integral.Collections;
using Microsoft.EntityFrameworkCore;

namespace Integral.Providers
{
    public abstract class EntityProvider<Entity> : VirtualQueryableCollection<Entity>, Provider<Entity>
        where Entity : class
    {
        private readonly DbSet<Entity> dbSet;

        protected EntityProvider(DbSet<Entity> dbSet) : base(dbSet) => this.dbSet = dbSet;

        public bool Find(object identity, out Entity entity)
        {
            entity = dbSet.Find(identity);
            return entity != default;
        }
    }
}