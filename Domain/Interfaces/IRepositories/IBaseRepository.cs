using Domain.Common;

namespace Domain.Repositories.Interfaces;

public interface IBaseRepository<T> where T : BaseEntity
{
    Task<T> Create(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(Guid id);
    Task<T> Get(Guid id);
    Task<ICollection<T>> GetAll();
}