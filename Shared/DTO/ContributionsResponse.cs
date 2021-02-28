using System.Collections.Generic;

namespace TTConfTool.Shared.DTO
{
    public class ContributionsResponse
    {
        public List<Contribution> Contributions { get; set; }
        public Dictionary<string, Speaker> Speaker { get; set; }
        public long ItemCount { get; set; }
        public Dictionary<string, Conference> Conferences { get; set; }
    }
}
