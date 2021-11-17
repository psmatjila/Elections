using AutoMapper;
using Elections.Dtos;

namespace Elections.Profiles
{
    public class ElectionsProfile : Profile
    {
        public ElectionsProfile()
        {
            //Create a mapping between a source object and a destination object
            CreateMap<IecParties, ElectionsReadDto>();
            CreateMap<ElectionsCreateDto, IecParties>();
            CreateMap<ElectionsUpdateDto, IecParties>();
        }
    }
}