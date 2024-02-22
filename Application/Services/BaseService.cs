using System;
using System.Collections.Generic;
using Application.Interfaces;
using AutoMapper;
using Domain.Common;
using Domain.Repositories.Interfaces;

public class BaseService<T, TInputModel, TViewModel> : IBaseService<T, TInputModel, TViewModel> where T : BaseEntity
{
    private readonly IBaseRepository<T> _repository;
    private readonly IMapper _mapper;

    public BaseService(IBaseRepository<T> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<TViewModel> Create(TInputModel inputModel)
    {
        var entity = _mapper.Map<T>(inputModel);
        var createdEntity = await _repository.Create(entity);
        return _mapper.Map<TViewModel>(createdEntity);
    }

    public async Task<TViewModel> Get(Guid id)
    {
        var entity = await _repository.Get(id);
        return _mapper.Map<TViewModel>(entity);
    }

    public async Task<TViewModel> Update(TInputModel inputModel)
    {
        var entity = _mapper.Map<T>(inputModel);
        var updatedEntity = await _repository.Update(entity);
        return _mapper.Map<TViewModel>(updatedEntity);
    }

    public async Task Delete(Guid id)
    {
        await _repository.Delete(id);
    }

    public async Task<IEnumerable<TViewModel>> GetAll()
    {
        var entities = await _repository.GetAll();
        return _mapper.Map<IEnumerable<TViewModel>>(entities);
    }
}