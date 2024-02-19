using Domain.Entities;
using Domain.Interfaces.IServices;
using Domain.Repositories.Interfaces;

namespace Application;

public class UserRepository : BaseService<User>, IUserService
{
    public UserRepository(IBaseRepository<User> repository) : base(repository)
    {
    }
}
