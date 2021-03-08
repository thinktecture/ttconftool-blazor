using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

        public async Task<List<Conference>> GetConferencesAsync(SearchFilter filter = null)
        {
            var queryString = QueryString.Create(filter.GetValue());
            
            return (await _httpClient.GetFromJsonAsync<ConferencesResponse>("conferences" + queryString.ToUriComponent())).Conferences;
        }

        public async Task AddConferenceAsync(Conference conference)
        {
            await _httpClient.PostAsJsonAsync<Conference>("conferences", conference);
        }

        public async Task UpdateConferenceAsync(Conference conference)
        {
            await _httpClient.PutAsJsonAsync<Conference>("conferences/" + conference.ID, conference);
        }
    }
}
