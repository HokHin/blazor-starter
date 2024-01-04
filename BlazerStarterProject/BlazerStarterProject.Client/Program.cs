using BlazerStarterProject.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

ServiceRegistration.RegisterServices(builder.Services);

await builder.Build().RunAsync();