using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using TTConfTool.Shared;

namespace TTConfTool.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddAuth0Authentication(options =>
            {
                builder.Configuration.Bind("Oidc", options.ProviderOptions);
            });

            CommonStartup.ConfigureServices(builder.Services, builder.Configuration);

            await builder.Build().RunAsync();
        }
    }
}
