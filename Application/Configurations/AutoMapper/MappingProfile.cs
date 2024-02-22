using Application.InputModels;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;

namespace Application.Configurations.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UserInputModel, User>().ReverseMap();
        CreateMap<User, UserViewModel>().ReverseMap();
    }
}
