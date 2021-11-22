using LuPerfect.Domain.ValueObjects;

namespace LuPerfect.Domain.Entities
{
    public sealed record AuditDeleted(DateTime At, string By) : ValueObject;
}