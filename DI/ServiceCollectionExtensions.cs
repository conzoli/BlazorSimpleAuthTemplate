using BlazorSimpleAuthTemplate.Services;

namespace BlazorSimpleAuthTemplate.DI;

public static class ServiceCollectionExtensions
{

    public static IServiceCollection AddUserAccountService(this IServiceCollection services)
    {
        services.AddScoped<IUserAccountService, InMemoryUserAccountService>();
        return services;
    }


    public static IServiceCollection AddLocalHttpClient(this IServiceCollection services)
    {
        services.AddHttpClient("local", HttpClient => {
            HttpClient.BaseAddress = new Uri("http://localhost:5007");
        });
        return services;
    }

}
