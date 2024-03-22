using Microsoft.Extensions.DependencyInjection;
using System.Net;

namespace _3ai.solutions.MailjetWrapper;

public static class DependencyInjection
{
    public static IServiceCollection AddMailjet(this IServiceCollection services, string publicKey, string privateKey)
    {
        
        services.AddHttpClient<MailjetClient>(
                o =>
                {
                })
                .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
                {
                    AutomaticDecompression = DecompressionMethods.All,
                }).ConfigurePrimaryHttpMessageHandler(serviceProvider =>
                {
                    return new HttpClientHandler()
                    {
                        PreAuthenticate = true,
                        Credentials = new NetworkCredential(publicKey, privateKey)
                    };
                });
        return services;
    }
}
