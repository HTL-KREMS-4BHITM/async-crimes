using System.Linq.Expressions;

namespace Domain;

public interface IRepositoryAsync<TEntity> where TEntity : class
{
    Task<TEntity> Create(TEntity t);

    Task<List<TEntity>> CreateRange(List<TEntity> list);

    Task Update(TEntity t);

    Task UpdateRange(List<TEntity> list);

    Task<TEntity>? Read(int id);

    Task<List<TEntity>> Read(Expression<Func<TEntity, bool>> filter);

    Task<List<TEntity>> Read(int start, int count);

    Task<List<TEntity>> ReadAll();

    Task Delete(TEntity t);
}