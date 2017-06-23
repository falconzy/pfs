using AutoMapper;
using pfs.Controllers.Resources;
using pfs.Core.model;

namespace pfs.Core
{
    public class MappingProfile :Profile {
        public MappingProfile() {
        // Add as many of these lines as you need to map your objects
        CreateMap<StockResource, Stock>();
        CreateMap<StockResource,StockTranscations>();
    }
    }
}