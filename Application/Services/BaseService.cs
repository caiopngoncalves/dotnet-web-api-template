using System;
using System.Collections.Generic;
using Domain.Common;
using Domain.Interfaces.IServices;
using Domain.Repositories.Interfaces;

public class BaseService<T> : IBaseService<T> where T : BaseEntity
{
    private readonly IBaseRepository<T> _repository;

    public BaseService(IBaseRepository<T> repository)
    {
        _repository = repository;
    }

    public Task<T> Create(T obj)
    {
        return _repository.Create(obj);
    }

    public Task<T> Get(Guid id)
    {
        return _repository.Get(id);
    }

    public Task<T> Update(T obj)
    {
        return _repository.Update(obj);
    }

    public Task<T> Delete(Guid id)
    {
       return _repository.Delete(id);
    }

    public Task<ICollection<T>> GetAll()
    {
        return _repository.GetAll();
    }
}
