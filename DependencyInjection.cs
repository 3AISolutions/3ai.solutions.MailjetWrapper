using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Text;

namespace _3ai.solutions.MailjetWrapper;

public static class DependencyInjection
{
    public static IServiceCollection AddMailjet(this IServiceCollection services, string publicKey, string privateKey)
    {


        services.AddHttpClient<MailjetClient>(
                o =>
                {
                    o.DefaultRequestHeaders.Add("Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{publicKey}:{privateKey}"))}");
                })
                .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
                {
                    AutomaticDecompression = DecompressionMethods.All,
                });
        return services;
    }
}
