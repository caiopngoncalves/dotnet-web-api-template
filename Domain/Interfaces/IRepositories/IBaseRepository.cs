using Domain.Common;

namespace Domain.Repositories.Interfaces;

public interface IBaseRepository<T> where T : BaseEntity
{
    Task<T> Create(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(T entity);
    Task<T> Get(Guid id, CancellationToken cancellationToken);
    Task<List<T>> GetAll(CancellationToken cancellationToken);
}