namespace LuPerfect.Domain.Entities
{
    public interface IAuditable<TKey> : IEntity<TKey>, IAuditable
        where TKey : struct
    { }
}
