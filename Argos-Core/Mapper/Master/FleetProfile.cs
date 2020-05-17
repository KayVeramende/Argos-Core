using Argos.Core.Model.Master;
using Argos_Core.Common;
using Argos_Core.View;
using AutoMapper;

namespace Argos_Core.Mapper.Master
{
    public class FleetProfile : Profile
    {
        public FleetProfile()
        {
            CreateMap<Fleet, FleetViewModel>()
                .ForMember(vm => vm.Timestamp, m => m.MapFrom(x => x.Timestamp.ByteArrayToString()));
        }
    }
}
