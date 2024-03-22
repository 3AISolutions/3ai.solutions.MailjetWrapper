
namespace _3ai.solutions.MailjetWrapper.Models;

public record SendResponseItem
{
    public string? Email { get; set; }
    public string? MessageUUID { get; set; }
    public string? MessageHref { get; set; }
    public long? MessageID { get; set; }
}
