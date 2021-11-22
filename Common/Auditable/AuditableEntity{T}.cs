namespace LuPerfect.Domain.Entities
{
    public abstract class AuditableEntity<TKey> : Entity<TKey>, IAuditable<TKey>
        where TKey : struct
    {
        public virtual AuditCreated Created { get; set; } = new(DateTime.UtcNow, "system");
        public virtual AuditUpdated? Updated { get; set; }
        public virtual AuditDeleted? Deleted { get; set; }

        public bool IsDeleted { get; set; }
    }
}