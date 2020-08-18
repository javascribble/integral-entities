using Integral.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Integral.Contexts
{
    public abstract class EntityContext<Context> : DbContext, Disposable
        where Context : DbContext
    {
        protected EntityContext(DbContextOptionsBuilder dbContextOptionsBuilder) : base(dbContextOptionsBuilder.Options) => Database.EnsureCreated();

        protected EntityContext(DbContextOptions<Context> dbContextOptions) : base(dbContextOptions) => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            base.OnConfiguring(dbContextOptionsBuilder);
            dbContextOptionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}