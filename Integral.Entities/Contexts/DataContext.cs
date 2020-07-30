using Integral.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Integral.Contexts
{
    public abstract class DataContext : DbContext, Disposable
    {
        protected DataContext(DbContextOptionsBuilder dbContextOptionsBuilder) : base(dbContextOptionsBuilder.Options) => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            base.OnConfiguring(dbContextOptionsBuilder);
            dbContextOptionsBuilder.UseLazyLoadingProxies();
        }
    }
}