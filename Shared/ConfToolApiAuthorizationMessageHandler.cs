using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace TTConfTool.Shared
{
    public class ConfToolApiAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        public ConfToolApiAuthorizationMessageHandler(IAccessTokenProvider provider,
            NavigationManager navigationManager)
            : base(provider, navigationManager)
        {
            ConfigureHandler(
                authorizedUrls: new[] { "https://api-ttconftool.azurewebsites.net/api/v1/" }
            );
        }

    }
}