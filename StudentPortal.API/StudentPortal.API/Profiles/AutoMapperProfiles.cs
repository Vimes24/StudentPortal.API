using AutoMapper;
using StudentPortal.API.DataModels;
using StudentPortal.API.DomainModels;
using StudentPortal.API.Profiles.AfterMaps;

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

            CreateMap<UpdateStudentRequest, DataModels.Student>()
                .AfterMap <UpdateStudentRequestAfterMap>();

        }
    }
}
