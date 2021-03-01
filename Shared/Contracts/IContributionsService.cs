using System.Collections.Generic;
using System.Threading.Tasks;
using TTConfTool.Shared.DTO;
using TTConfTool.Shared.ViewModels;

namespace TTConfTool.Shared.Contracts
{
    public interface IContributionsService
    {
        Task<List<Contribution>> GetContributionsAsync();
        Task<List<ListViewContribution>> GetListViewContributionsAsync();
    }
}
