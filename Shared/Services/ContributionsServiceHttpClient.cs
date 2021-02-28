using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TTConfTool.Shared.Contracts;
using TTConfTool.Shared.DTO;

namespace TTConfTool.Shared.Services
{
    public class ContributionsServiceHttpClient : IContributionsService
    {
        private HttpClient _httpClient;

        public ContributionsServiceHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Contribution>> ListContributionsAsync()
        {
            return (await _httpClient.GetFromJsonAsync<ContributionsResponse>("contributions")).Contributions;
        }
    }
}