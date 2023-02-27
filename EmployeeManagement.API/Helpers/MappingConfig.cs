using AutoMapper;
using EmployeeManagement.API.DTOs.Address;
using EmployeeManagement.API.DTOs.Job;
using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.Helpers
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            //Address Mapping
            CreateMap<AddressCreate, Address>().ForMember(dest => dest.Id, opt =>opt.Ignore()).ReverseMap();
            CreateMap<AddressUpdate, Address>().ReverseMap();
            CreateMap<AddressGet, Address>().ReverseMap();

            //Job Mapping
            CreateMap<JobCreate, Job>().ForMember(dest => dest.Id, opt => opt.Ignore()).ReverseMap();
            CreateMap<JobUpdate, Job>().ReverseMap();
            CreateMap<JobGet, Job>().ReverseMap();
        }
    }
}
