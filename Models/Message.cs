
namespace _3ai.solutions.MailjetWrapper.Models;

public record Message
{
    public Contact? From { get; set; }
    public List<Contact>? To { get; set; }
    public List<Contact>? CC { get; set; }
    public List<Contact>? BCC { get; set; }
    public int TemplateID { get; set; }
    public bool TemplateLanguage { get; set; } = true;
    public List<Attachment>? Attachments { get; set; }
    public string? Subject { get; set; }
    public Dictionary<string, string>? Variables { get; set; }
}
