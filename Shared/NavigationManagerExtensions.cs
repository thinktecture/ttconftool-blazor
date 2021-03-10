using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;

namespace TTConfTool.Shared
{
    public static class NavigationManagerExtensions
    {
        public static void AddQueryString(this NavigationManager navigationManager, string name, string value)
        {
            var query = new Dictionary<string, string> { { name, value } };
            navigationManager.NavigateTo(QueryHelpers.AddQueryString(navigationManager.Uri, query));
        }

        public static string GetQueryString(this NavigationManager navigationManager, string name)
        {
            var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);

            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(name, out var param))
            {
                var value = param.First();
                return value;
            }

            return string.Empty;
        }
    }
}
