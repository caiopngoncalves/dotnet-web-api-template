using Domain.Common;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    protected readonly AppDbContext Context;

    public BaseRepository(AppDbContext context)
    {
        Context = context;
    }
    public async Task<T> Create(T entity)
    {
        Context.Set<T>().Add(entity);
        await Context.SaveChangesAsync();
        return entity;
    }
    public async Task<T> Update(T entity)
    {
        var result = await Context.Set<T>().FindAsync(entity.Id);
        if (result == null)
        {
            throw new Exception($"Entity {nameof(T)} with id {entity.Id} not found");
        }

        Context.Set<T>().Update(entity);
        await Context.SaveChangesAsync();
        return entity;
    }
    public async Task<T> Delete(T entity)
    {
        var result = await Context.Set<T>().FindAsync(entity.Id);
        if (result == null)
        {
            throw new Exception($"Entity {nameof(T)} with id {entity.Id} not found");
        }
        Context.Set<T>().Remove(entity);
        await Context.SaveChangesAsync();
        return entity;
    }
    public async Task<T> Get(Guid id, CancellationToken cancellationToken)
    {
        var entity = await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        if (entity == null)
        {
            throw new Exception($"Entity {nameof(T)} with id {id} not found");
        }
        return entity;
    }
    public async Task<List<T>> GetAll(CancellationToken cancellationToken)
    {
        return await Context.Set<T>().ToListAsync(cancellationToken);
    }
}
