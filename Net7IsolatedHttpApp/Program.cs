using Microsoft.Azure.Functions.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Net7IsolatedHttpApp;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(s =>
    {
        s.AddSingleton<IFunctionMetadataProvider, Microsoft.Azure.Functions.Worker.GeneratedFunctionMetadataProvider>();
    })
    .Build();

host.Run();
