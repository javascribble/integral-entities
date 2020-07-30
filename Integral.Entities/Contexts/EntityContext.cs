using Microsoft.EntityFrameworkCore;

namespace Integral.Contexts
{
    public abstract class EntityContext : DataContext
    {
        protected EntityContext(DbContextOptionsBuilder dbContextOptionsBuilder) : base(dbContextOptionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}