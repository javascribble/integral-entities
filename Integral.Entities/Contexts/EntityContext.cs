using Integral.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Integral.Contexts
{
    public abstract class EntityContext : DbContext, Disposable
    {
        protected EntityContext(DbContextOptions dbContextOptions) : base(dbContextOptions) => Database.EnsureCreated();

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