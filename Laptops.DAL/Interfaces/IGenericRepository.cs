using System.Linq.Expressions;

namespace Laptops.DAL.Interfaces;

public interface IGenericRepository<T>
    where T : class
{
    Task<T> CreateAsync(T entity);

    IQueryable<T> SelectAll(
        Expression<Func<T, bool>>? expression = null);

    Task<T?> SelectByIdAsync(long id);

    T Update(T entity);

    void Delete(T entity);

    Task<bool> SaveAsync();
}