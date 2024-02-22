using Domain.Common;

namespace Application.Interfaces;
public interface IBaseService<T, TInputModel, TViewModel> where T : BaseEntity
{
    Task<TViewModel> Create(TInputModel inputModel);
    Task<TViewModel> Get(Guid id);
    Task<TViewModel> Update(TInputModel inputModel);
    Task Delete(Guid id);
    Task<IEnumerable<TViewModel>> GetAll();
}