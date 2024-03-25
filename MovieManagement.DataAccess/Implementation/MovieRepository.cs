using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entity;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementation;

public class MovieRepository : GenericRepository<Movie>, IMovieRepository
{
    readonly MovieManagementDbContext _dbContext;
    public MovieRepository(MovieManagementDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }


}
