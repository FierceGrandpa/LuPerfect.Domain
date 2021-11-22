namespace LuPerfect.Domain.Entities
{
    public interface IAuditable : IEntity, ISoftDeletable
    {
        AuditCreated Created { get; set; }

        AuditUpdated? Updated { get; set; }
    }
}
