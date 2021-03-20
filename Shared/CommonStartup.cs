using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using System;
using TTConfTool.Shared.Contracts;
using TTConfTool.Shared.Services;

namespace TTConfTool.Shared
{
    public static class CommonStartup
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration config)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<ConfToolApiAuthorizationMessageHandler>();

            services.AddHttpClient<IConferencesService, ConferencesServiceHttpClient>(client =>
                client.BaseAddress = new Uri(config["ConfToolApi"]));
            //.AddHttpMessageHandler<ConfToolApiAuthorizationMessageHandler>();

            services.AddHttpClient<IContributionsService, ContributionsServiceHttpClient>(client =>
                client.BaseAddress = new Uri(config["ConfToolApi"]));
            //.AddHttpMessageHandler<ConfToolApiAuthorizationMessageHandler>();

            services.AddHttpClient<ISpeakersService, SpeakersServiceHttpClient>(client =>
                client.BaseAddress = new Uri(config["ConfToolApi"]));
            //.AddHttpMessageHandler<ConfToolApiAuthorizationMessageHandler>();

            services.AddMudServices();
        }
    }
}
