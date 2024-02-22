using Application.InputModels;
using Application.ViewModels;
using Domain.Entities;

namespace Application.Interfaces;

public interface IUserService : IBaseService<User, UserInputModel, UserViewModel>
{

}
