using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementation;

public class UnitOfWork : IUnitOfWork
{
    private readonly MovieManagementDbContext _dbContext;

    public UnitOfWork(MovieManagementDbContext dbContext)
    {
       _dbContext = dbContext;
        Actor = new ActorRepository(_dbContext);
        Movie = new MovieRepository(_dbContext);
        Genre = new GenreRepository(_dbContext);
        Biography = new BiographyRepository(_dbContext);
    }

    public IActorRepository Actor { get; private set; }
    public IMovieRepository Movie { get; private set; }
    public IBiographyRepository Biography { get; private set; }
    public IGenreRepository Genre { get; private set; }

    public void Dispose()
    {
        _dbContext.Dispose();
    }

    public int Save()
    {
        return _dbContext.SaveChanges();    
    }
}
