using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TTConfTool.Shared;

namespace TTConfTool.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            CommonStartup.ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }
    }
}
