using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AutoMapper;
using TTConfTool.Shared.Contracts;
using TTConfTool.Shared.DTO;
using TTConfTool.Shared.ViewModels;

namespace TTConfTool.Shared.Services
{
    public class ContributionsServiceHttpClient : IContributionsService
    {
        private HttpClient _httpClient;
        private IMapper _mapper;

        public ContributionsServiceHttpClient(HttpClient httpClient, IMapper mapper)
        {
            _httpClient = httpClient;
            _mapper = mapper;
        }

        public async Task<List<Contribution>> GetContributionsAsync()
        {
            return (await _httpClient.GetFromJsonAsync<ContributionsResponse>("contributions")).Contributions;
        }

        public async Task<List<ListViewContribution>> GetListViewContributionsAsync()
        {
            var contributions = (await _httpClient.GetFromJsonAsync<ContributionsResponse>("contributions")).Contributions;
            var result = _mapper.Map<List<ListViewContribution>>(contributions);

            return result;
        }
    }
}