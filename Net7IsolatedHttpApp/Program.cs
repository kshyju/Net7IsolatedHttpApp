using Microsoft.Azure.Functions.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Net7IsolatedHttpApp;
using System.Reflection;
using System.Runtime.Loader;

//var pathToAssembly = "C:\\Dev\\Temp\\AOTPlayground\\Net7IsolatedHttpApp\\Net7IsolatedHttpApp\\bin\\Debug\\net7.0\\Net7IsolatedHttpApp.dll";
//Console.WriteLine("pathToAssembly1:" + pathToAssembly);
//Assembly assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(pathToAssembly);

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(s =>
    {
        s.AddSingleton<IFunctionMetadataProvider, Microsoft.Azure.Functions.Worker.GeneratedFunctionMetadataProvider>();
    })
    .Build();

host.Run();
