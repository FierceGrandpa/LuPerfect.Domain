using System.ComponentModel.DataAnnotations;

namespace LuPerfect.Domain.Entities
{
    public interface IEntity<out TKey> : IEntity
        where TKey : struct
    {
        [Key]
        TKey Id { get; }
    }
}
