using AutoMapper;
using Business.Models;
using FluenteValidations.ViewModels;

namespace FluenteValidations.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<TagViewModel, Tag>().ReverseMap();
        }
    }
}
