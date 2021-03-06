using System.Collections.Generic;
using System.Threading.Tasks;
using TTConfTool.Shared.DTO;

namespace TTConfTool.Shared.Contracts
{
    public interface ISpeakersService
    {
        Task<List<Speaker>> GetSpeakersAsync();
    }
}
