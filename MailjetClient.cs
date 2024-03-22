using _3ai.solutions.MailjetWrapper.Models;
using System.Text.Json;
using System.Text;
using System.Net.Http.Json;


namespace _3ai.solutions.MailjetWrapper;

public class MailjetClient
{

    private readonly HttpClient _httpClient;

    public MailjetClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
     

    public async Task<SendResponse?> SendMessageAsync(SendRequest sendRequest, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.PostAsync($"https://api.mailjet.com/v3.1/send", new StringContent(JsonSerializer.Serialize(sendRequest), Encoding.UTF8, "application/json"), cancellationToken);
        return await response.Content.ReadFromJsonAsync<SendResponse>(cancellationToken: cancellationToken);
    }
}
