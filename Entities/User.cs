using LuPerfect.Domain.Enums;
using LuPerfect.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace LuPerfect.Domain.Entities
{
    public record Verification(VerificationToken Token, DateTime? At);
    public record PasswordReset(ResetToken Token, DateTime At);

    public class User : AuditableEntity<int>
    {
        private Name _name = new(string.Empty, string.Empty);
        private string _email = string.Empty; 
        private string _password = string.Empty;

        [Required]
        public Name FullName
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(FullName));
        }

        [Required]
        [EmailAddress]
        public string Email
        {
            get => _email;
            set => _email = value ?? throw new ArgumentNullException(nameof(Email));
        }

        [Required]
        public string PasswordHash
        {
            get => _password;
            set => _password = value ?? throw new ArgumentNullException(nameof(PasswordHash));
        }

        public Role Role { get; set; }
        
        public Verification? Verification { get; set; }
        public bool IsVerified => Verification is not null && Verification.At.HasValue;
        public PasswordReset? PasswordReset { get; set; }
        
        public ICollection<RefreshToken> RefreshTokens { get; } = new HashSet<RefreshToken>();

        public bool OwnsToken(string token) => RefreshTokens?.FirstOrDefault(e => e == token) is not null;
    }
}