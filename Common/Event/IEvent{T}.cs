using LuPerfect.Domain.Entities;

namespace LuPerfect.Domain.Events
{
    public interface IEvent<out TEntity, TKey> : IEvent<TEntity>
        where TEntity : class, IEntity<TKey>
        where TKey : struct
    {}
}