namespace LuPerfect.Domain.Entities
{
    public interface ISoftDeletable
    {
        AuditDeleted? Deleted { get; set; }

        bool IsDeleted { get; set; }
    }
}
