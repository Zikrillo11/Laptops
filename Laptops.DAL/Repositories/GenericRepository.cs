using System.Linq.Expressions;
using Laptops.DAL.Data;
using Laptops.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Laptops.DAL.Repositories;

public class GenericRepository<T> : IGenericRepository<T>
    where T : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<T> CreateAsync(T entity)
    {
        await _dbSet.AddAsync(entity);

        return entity;
    }

    public IQueryable<T> SelectAll(
        Expression<Func<T, bool>>? expression = null)
    {
        return expression is null
            ? _dbSet
            : _dbSet.Where(expression);
    }

    public async Task<T?> SelectByIdAsync(long id)
    {
        return await _dbSet.FindAsync(id);
    }

    public T Update(T entity)
    {
        _dbSet.Update(entity);

        return entity;
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task<bool> SaveAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}