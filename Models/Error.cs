namespace _3ai.solutions.MailjetWrapper.Models;

public record Error
{
    public string? ErrorIdentifier { get; set; }
    public string? ErrorCode { get; set; }
    public int ? StatusCode { get; set; }
    public string? ErrorMessage { get; set; }
    public List<string>? ErrorRelatedTo { get; set; }
}
