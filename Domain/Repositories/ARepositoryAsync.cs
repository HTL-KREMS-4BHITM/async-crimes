using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Model;
namespace Domain.Repositories;

public abstract class ARepositoryAsync<TEntity> : IRepositoryAsync<TEntity> where TEntity : class
{
    private readonly CrimesContext _context;    
    private readonly DbSet<TEntity> _dbSet;    
    public ARepositoryAsync(CrimesContext context)    
    {       
        _context = context;        
        _dbSet = _context.Set<TEntity>();    
    }    public async Task<TEntity> Create(TEntity entity)    
    {        
        _dbSet.Add(entity);        
        await _context.SaveChangesAsync();        
        return entity;    
    }

    public async Task<List<TEntity>> CreateRange(List<TEntity> entities)
    {
        _dbSet.AddRange(entities);        
        await _context.SaveChangesAsync();        
        return entities;
    }

    public async Task Update(TEntity entity)
    {
        _dbSet.Update(entity);        
        await _context.SaveChangesAsync();
    }

    public async Task UpdateRange(List<TEntity> entities)
    {
        _context.ChangeTracker.Clear();        
        _dbSet.UpdateRange(entities);        
        await _context.SaveChangesAsync();
    }

    public async Task<TEntity> Read(int id)
    {
        return (await _dbSet.FindAsync(id))!;
    }

    public async Task<List<TEntity>> Read(Expression<Func<TEntity, bool>> filter)
    {
        return await _dbSet.Where(filter).ToListAsync();
    }

    public async Task<List<TEntity>> Read(int start, int count)
    {
        return await _dbSet.Skip(start).Take(count).ToListAsync();
    }

    public async Task<List<TEntity>> ReadAll()
    {
        return await _dbSet.ToListAsync();    
        
    }

    public async Task Delete(TEntity entity)
    {
        _dbSet.Remove(entity);        
        await _context.SaveChangesAsync();
    }
}
