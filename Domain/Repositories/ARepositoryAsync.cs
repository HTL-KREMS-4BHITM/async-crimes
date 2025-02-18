using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Domain.Repositories;

public class ARepositoryAsync<TEntity> : IRepositoryAsync<TEntity> where TEntity : class
{
    private readonly CrimesContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public ARepositoryAsync(CrimesContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public async Task<TEntity> Create(TEntity entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public async Task<List<TEntity>> CreateRange(List<TEntity> entities)
    {
        _dbSet.AddRange(entities);
        _context.SaveChanges();
        return entities;
    }

    public async Task Update(TEntity entity)
    {
        _dbSet.Update(entity);
        _context.SaveChanges();
    }

    public async Task UpdateRange(List<TEntity> entities)
    {
        _context.ChangeTracker.Clear();
        _dbSet.UpdateRange(entities);
        _context.SaveChanges();
    }

    public async Task<TEntity>? Read(int id)
    {
        return _dbSet.Find(id);
    }

    public async Task<List<TEntity>> Read(Expression<Func<TEntity, bool>> filter)
    {
        return _dbSet.Where(filter).ToList();
    }

    public async Task<List<TEntity>> Read(int start, int count)
    {
        return _dbSet.Skip(start).Take(count).ToList();
    }

    public async Task<List<TEntity>> ReadAll()
    {
        return _dbSet.ToList();
    }

    public async Task Delete(TEntity entity)
    {
        _dbSet.Remove(entity);
        _context.SaveChanges();
    }
}