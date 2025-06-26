using Microsoft.Extensions.DependencyInjection;

namespace WhereAtm.Application.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(m => m.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection)));
        return services;
    }
}