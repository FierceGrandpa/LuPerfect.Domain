using LuPerfect.Domain.ValueObjects;

namespace LuPerfect.Domain.Entities
{
    public sealed record AuditUpdated(DateTime? At, string By) : ValueObject;
}