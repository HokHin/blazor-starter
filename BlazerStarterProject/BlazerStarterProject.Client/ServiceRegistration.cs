using Fluxor;

namespace BlazerStarterProject.Client;

public class ServiceRegistration
{
    public static void RegisterServices(IServiceCollection services)
    {
        // Add Fluxor State Management
        services.AddFluxor(options => options.ScanAssemblies(typeof(Program).Assembly).UseReduxDevTools());
        
        // Add Http Client (APIs)
        services.AddHttpClient();
    }
}