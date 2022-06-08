using AutoMapper;
using StudentPortal.API.DataModels;
using StudentPortal.API.DomainModels;

namespace StudentPortal.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, StudentDM>()
                .ReverseMap();

            CreateMap<Gender, GenderDM>()
                .ReverseMap();

            CreateMap<Address, AddressDM>()
                .ReverseMap();
        }
    }
}
