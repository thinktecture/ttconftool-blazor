using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TTConfTool.Shared.Contracts;
using TTConfTool.Shared.DTO;

namespace TTConfTool.Shared.Services
{
    public class SpeakersServiceHttpClient : ISpeakersService
    {
        private HttpClient _httpClient;

        public SpeakersServiceHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Speaker>> GetSpeakersAsync()
        {
            return (await _httpClient.GetFromJsonAsync<SpeakersResponse>("speaker")).Speaker;
        }
    }
}
