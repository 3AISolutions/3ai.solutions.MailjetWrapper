using System;
namespace _3ai.solutions.MailjetWrapper.Models;

public record ResponseMessage
{
    public string? Status {  get; set; }    
    public string? CustomID { get; set; }
    public List<Error>? Errors { get; set; }
    public List<SendResponseItem>? To { get; set; }
    public List<SendResponseItem>? Cc { get; set; }
    public List<SendResponseItem>? Bcc { get; set; }
}
