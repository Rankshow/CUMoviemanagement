using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementation;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    readonly MovieManagementDbContext _dbContext;
    public GenericRepository(MovieManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public void Add(T entity)
    {
        _dbContext.Add(entity);
    }

    public void AddRange(IEnumerable<T> entities)
    {
        _dbContext.Set<T>().AddRange(entities);
    }

    public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
    {
        return _dbContext.Set<T>().Where(predicate);
    }

    public IEnumerable<T> GetAll()
    {
        return _dbContext.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return _dbContext.Set<T>().Find(id);
    }

    public void Remove(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _dbContext.Set<T>().RemoveRange(entities);
    }
}
