using Application.InputModels;
using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories.Interfaces;

namespace Application.Services;

public class UserService : BaseService<User, UserInputModel, UserViewModel>, IUserService
{
    public UserService(IUserRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
    // Implement any additional methods defined in IUserService
}