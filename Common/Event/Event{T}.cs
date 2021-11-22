using LuPerfect.Domain.Entities;

namespace LuPerfect.Domain.Events
{
    public abstract class Event<TEntity, TKey> : Entity<Guid>, IEvent<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
        where TKey : struct
    {
        public bool IsPublished { get; protected set; }

        public int EntityId { get; protected set; }
        public TEntity Entity { get; protected set; }

        protected Event(TEntity entity) : base(Guid.NewGuid())
        {
            Entity = entity;
        }

        public virtual DateTimeOffset DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}