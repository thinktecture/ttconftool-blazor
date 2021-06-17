using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using TTConfTool.Shared;
using TTConfTool.UI;

namespace TTConfTool.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Need to force assembly loading (https://github.com/dotnet/aspnetcore/issues/26601)
            typeof(App).ToString();

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddOidcAuthentication(options =>
            {
                builder.Configuration.Bind("Oidc", options.ProviderOptions);
            });

            CommonStartup.ConfigureServices(builder.Services, builder.Configuration);

            await builder.Build().RunAsync();
        }
    }
}
