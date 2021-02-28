using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TTConfTool.Shared.Contracts;
using TTConfTool.Shared.DTO;

namespace TTConfTool.Shared.Services
{
    public class ConferencesServiceHttpClient : IConferencesService
    {
        private HttpClient _httpClient;

        public ConferencesServiceHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Conference>> ListConferencesAsync()
        {
            return (await _httpClient.GetFromJsonAsync<ConferencesResponse>("conferences")).Conferences;
        }
    }
}
