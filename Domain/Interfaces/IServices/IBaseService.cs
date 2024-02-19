using Domain.Common;

namespace Domain.Interfaces.IServices;
    public interface IBaseService<T> where T : BaseEntity
    {
        Task<T> Create(T obj);
        Task<T> Get(Guid id);
        Task<T> Update(T obj);
        Task<T> Delete(Guid id);
        Task<ICollection<T>> GetAll();
    }