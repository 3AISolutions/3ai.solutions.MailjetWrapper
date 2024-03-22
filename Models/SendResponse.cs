namespace _3ai.solutions.MailjetWrapper.Models;

public record SendResponse
{
    public List<ResponseMessage>? Messages { get; set; }
}
