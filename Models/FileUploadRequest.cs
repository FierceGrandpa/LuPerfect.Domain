namespace LuPerfect.Domain.Models
{
    public struct FileUploadRequest
    {
        public string Name { get; init; }
        public string Extension { get; init; }
        public string Data { get; init; }
    }
}
