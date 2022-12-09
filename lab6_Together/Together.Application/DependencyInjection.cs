namespace Together.Application;

using Microsoft.Extensions.DependencyInjection;
using Together.Application.Services;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IEventService,EventService>();
        return services;
    }
}