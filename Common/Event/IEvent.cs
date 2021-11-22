using LuPerfect.Domain.Entities;

namespace LuPerfect.Domain.Events
{
    public interface IEvent<out TEntity> : IEntity<Guid>
        where TEntity : class, IEntity
    {
        public bool IsPublished { get; }

        public int EntityId { get; }
        public TEntity Entity { get; }

        DateTimeOffset DateOccurred { get; }
    }
}