using AutoMapper;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
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
            var response = await _httpClient.GetFromJsonAsync<ContributionsResponse>("contributions");

            var sw = new Stopwatch();
            sw.Start();

            var listViewContributions = _mapper.Map<List<ListViewContribution>>(response.Contributions);

            listViewContributions.ForEach(listViewContribution =>
            {
                if (listViewContribution.Conference != null)
                {
                    listViewContribution.Conference = response.Conferences.Where(c => c.Key == listViewContribution.Conference.ID).First().Value;
                }

                listViewContribution.Speakers = listViewContribution.Speakers.Select(speaker => response.Speaker.Where(s => s.Key == speaker.ID).First().Value).ToList();
                listViewContribution.SpeakersString = string.Join(", ", listViewContribution.Speakers.Select(s => s.FirstName + " " + s.LastName).ToList()); ;
            });

            sw.Stop();
            System.Console.WriteLine("***ELAPSED - GetListViewContributionsAsync MAPPING: " + sw.ElapsedMilliseconds);

            return listViewContributions;
        }
    }
}