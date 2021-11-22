using System.ComponentModel.DataAnnotations;

namespace LuPerfect.Domain.Entities
{
    public abstract class Entity<TKey> : IEntity<TKey>
        where TKey : struct
    {
        [Key]
        public TKey Id { get; }

        protected Entity() { }

        protected Entity(TKey id) => Id = id;

        public override int GetHashCode() => Id.Equals(default) 
            ? base.GetHashCode() 
            : GetType().GetHashCode() * 907 + Id.GetHashCode();

        public override string ToString() => $"{GetType().Name} [Id={Id}]";
    }
}
