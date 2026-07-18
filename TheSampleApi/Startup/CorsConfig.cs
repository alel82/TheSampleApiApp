namespace TheSampleApi.Startup;

public static class CorsConfig
{
    private const string _allowAllPolicy = "AllowAll";

    public static void AddCorsServices(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(_allowAllPolicy, policy =>
            {
                policy.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });
        });
    }

    public static void ApplyCorsConfig(this WebApplication app)
    {
        app.UseCors(_allowAllPolicy);
    }
}
