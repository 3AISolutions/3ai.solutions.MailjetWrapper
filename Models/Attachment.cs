namespace _3ai.solutions.MailjetWrapper.Models;

public record Attachment
{
    public string ContentType { get; set; } = string.Empty;
    public string Filename { get; set; } = string.Empty;
    public string Base64Content { get; set; } = string.Empty;
}
