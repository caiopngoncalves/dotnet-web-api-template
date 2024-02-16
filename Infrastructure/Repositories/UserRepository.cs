using Domain.Entities;
using Domain.Repositories.Interfaces;

namespace Infrastructure.Repositories;
public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
}
