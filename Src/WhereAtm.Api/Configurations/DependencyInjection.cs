using WhereAtm.Application.Configurations;

namespace WhereAtm.Api.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddApplication();

        return services;
    }
}