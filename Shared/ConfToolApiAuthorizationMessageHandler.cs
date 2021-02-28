using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Configuration;

namespace TTConfTool.Shared
{
    public class ConfToolApiAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        public ConfToolApiAuthorizationMessageHandler(IAccessTokenProvider provider,
            NavigationManager navigationManager, IConfiguration config)
            : base(provider, navigationManager)
        {
            ConfigureHandler(
                authorizedUrls: new[] { config["ConfToolApi"] }
            );
        }
    }
}