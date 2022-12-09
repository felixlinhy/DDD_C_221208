namespace Together.Infrastructure;

using Microsoft.Extensions.DependencyInjection;
using Together.Application.Common.Interfaces;
using Together.Infrastructure.Persistence;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IEventRepository,EventMemRepository>();
        return services;
    }
}