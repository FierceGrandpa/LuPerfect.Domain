namespace LuPerfect.Domain.Entities
{
    public abstract class AuditableEntity : Entity, IAuditable
    {
        public virtual AuditCreated Created { get; set; } = new(DateTime.UtcNow, "system");
        public virtual AuditUpdated? Updated { get; set; }
        public virtual AuditDeleted? Deleted { get; set; }

        public bool IsDeleted { get; set; }
    }
}