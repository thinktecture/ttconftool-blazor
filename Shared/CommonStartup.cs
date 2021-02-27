using System;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using TTConfTool.Shared.Contracts;
using TTConfTool.Shared.Services;

namespace TTConfTool.Shared
{
    public static class CommonStartup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient<IConferencesService, ConferencesServiceHttpClient>(client =>
                client.BaseAddress = new Uri("https://api-ttconftool.azurewebsites.net/api/v1/"));

            services.AddMudServices();
        }
    }
}
