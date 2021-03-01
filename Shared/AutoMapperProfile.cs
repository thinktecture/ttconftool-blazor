using AutoMapper;
using TTConfTool.Shared.DTO;
using TTConfTool.Shared.ViewModels;

namespace TTConfTool.Shared
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<long, Speaker>().ForMember(dest => dest.ID, opts => opts.MapFrom(src => src));
            CreateMap<Contribution, ListViewContribution>().ForMember(dest => dest.Speakers, opts => opts.MapFrom(src => src.Speaker));
            CreateMap<long, Conference>().ForMember(dest => dest.ID, opts => opts.MapFrom(src => src));
        }
    }
}
