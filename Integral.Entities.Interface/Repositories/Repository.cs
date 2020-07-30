using Integral.Aggregates;
using Integral.Providers;

namespace Integral.Repositories
{
    public interface Repository<Entity> : DirectAggregate<Entity>, Provider<Entity>
        where Entity : notnull
    {
    }
}