namespace LuPerfect.Domain.Models
{
    public struct MailRequest
    {
        public string To { get; init; }
        public string Subject { get; init; }
        public string Body { get; init; }
        public string From { get; init; }
    }
}
