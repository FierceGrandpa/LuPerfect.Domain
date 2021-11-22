namespace LuPerfect.Domain.Entities
{
    public record TokenCreated(DateTime At, string ByIp);
    public record TokenRevoked(DateTime At, string ByIp, string? ByToken, string? Reason);

    public class RefreshToken : Token
    {
        public TokenCreated Created { get; set; } = new(DateTime.UtcNow, "system");
        public TokenRevoked? Revoked { get; set; }

        public void Revoke(string ip, string? reason = null, string? byToken = null)
        {
            Revoked = new(DateTime.UtcNow, ip, byToken, reason);
        }

        public bool IsRevoked => Revoked is not null;
        public bool IsActive => !IsRevoked && !IsExpired;
    }
}