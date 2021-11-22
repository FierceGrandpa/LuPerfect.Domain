using LuPerfect.Domain.ValueObjects;

namespace LuPerfect.Domain.Entities
{
    public sealed record AuditCreated(DateTime At, string By) : ValueObject;
}