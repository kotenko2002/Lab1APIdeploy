using AutoMapper;
using Lab1API.Models;

namespace Lab1API.DTOs.Mapper
{
    public class ControllersProfile : Profile
    {
        public ControllersProfile()
        {
            CreateMap<UserAddModel, User>();
            CreateMap<CategoryAddModel, Category>();
            CreateMap<RecordAddModel, Record>(); 
        }
    }
}
