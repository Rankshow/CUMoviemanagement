using Microsoft.EntityFrameworkCore;
using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entity;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementation;

public class ActorRepository : GenericRepository<Actor> , IActorRepository
{
    readonly MovieManagementDbContext _dbContext;
    public ActorRepository(MovieManagementDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext; 
    }

    public IEnumerable<Actor> GetActorsWithMovies()
    {
        var actorsWithMovies = _dbContext.Actors.Include(a => a.Movies).ToList();
        return actorsWithMovies;
    }

    public Actor Remove(int actorId)
    {
        var delActorId = _dbContext.Actors.Where( x => x.Id == actorId ).FirstOrDefault();  
        if (delActorId != null)
        {
            _dbContext.Actors.Remove(delActorId);
            _dbContext.SaveChanges();
        }
        return delActorId ?? new Actor();
    }
    public Actor GetByActorId(int actorId)
    {
        var actor = _dbContext.Actors.Where(p => p.Id == actorId).FirstOrDefault();
        if (actor != null) 
        {
            _dbContext.Add(actor);
            
        }
        return actor ?? new Actor();
    }
}
