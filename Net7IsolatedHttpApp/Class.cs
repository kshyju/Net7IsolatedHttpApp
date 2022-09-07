//using Microsoft.Azure.Functions.Core;
//using Microsoft.Azure.Functions.Worker.Core.FunctionMetadata;
//using System;
//using System.Collections.Generic;
//using System.Collections.Immutable;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;

//namespace Net7IsolatedHttpApp
//{
//    public class GeneratedFunctionMetadataProvider : IFunctionMetadataProvider
//    {
//        public Task<ImmutableArray<IFunctionMetadata>> GetFunctionMetadataAsync(string directory)
//        {
//            var metadataList = new List<IFunctionMetadata>();
//            var Function1RawBindings = new List<string>();
//            var Function1reqBinding = new
//            {
//                name = "req",
//                type = "HttpTrigger",
//                direction = "In",
//                authLevel = "Anonymous",
//                methods = new List<string> { "get", "post" },
//            };
//            var Function1reqBindingJSONstring = JsonSerializer.Serialize(Function1reqBinding);
//            Function1RawBindings.Add(Function1reqBindingJSONstring);
//            var Function1returnBinding = new
//            {
//                name = "$return",
//                type = "http",
//                direction = "Out",
//            };
//            var Function1returnBindingJSONstring = JsonSerializer.Serialize(Function1returnBinding);
//            Function1RawBindings.Add(Function1returnBindingJSONstring);
//            var Function1 = new DefaultFunctionMetadata
//            {
//                FunctionId = Guid.NewGuid().ToString(),
//                Language = "dotnet-isolated",
//                Name = "Function1",
//                EntryPoint = "Net7IsolatedHttpApp.Function1.Run",
//                RawBindings = Function1RawBindings,
//                ScriptFile = "Net7IsolatedHttpApp.dll"
//            };
//            metadataList.Add(Function1);
//            return Task.FromResult(metadataList.ToImmutableArray());
//        }
//        public enum AuthorizationLevel
//        {
//            Anonymous,
//            User,
//            Function,
//            System,
//            Admin
//        }
//    }
//}
