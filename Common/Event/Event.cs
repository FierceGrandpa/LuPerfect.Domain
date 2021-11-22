using LuPerfect.Domain.Entities;

namespace LuPerfect.Domain.Events
{
    public abstract class Event<TEntity> : Entity<Guid>, IEvent<TEntity>
        where TEntity : class, IEntity
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