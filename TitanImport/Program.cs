using Blazor.FileReader;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace TitanImport
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddBaseAddressHttpClient();
            builder.Services.AddFileReaderService(options => options.UseWasmSharedBuffer = true);
            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();
        }
    }
}
