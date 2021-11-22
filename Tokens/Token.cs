using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LuPerfect.Domain.Entities
{
    [Owned]
    public class Token : Entity<Guid>
    {
        private string _value = string.Empty;

        public User? User { get; set; }

        [Required]
        public string Value
        {
            get => _value;
            set => _value = value ?? throw new ArgumentNullException(nameof(Value));
        }
        public DateTime Expires { get; set; }

        public bool IsExpired => DateTime.UtcNow >= Expires;

        public static implicit operator string(Token token) => token.Value;
    }
}
