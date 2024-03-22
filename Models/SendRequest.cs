
namespace _3ai.solutions.MailjetWrapper.Models;

public record SendRequest
{
    public List<Message> Messages { get; set; } = new();
}
