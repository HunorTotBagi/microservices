using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //services.AddMediatoR(cfg => {
        //      cfg.RegisterServicesFromAssembly(Assembly.GetExectuingAssemlby());
        //});

        return services;
    }
}
