using Microsoft.Azure.Functions.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    // Use the source generated metadagenerator insetad of the reflection based one
    .ConfigureServices(s =>
    {
        s.AddSingleton<IFunctionMetadataProvider, Microsoft.Azure.Functions.Worker.GeneratedFunctionMetadataProvider>();
    })
    .Build();

host.Run();
