using MovieManagement.Domain.Entity;

namespace MovieManagement.Domain.Repository;

public interface IActorRepository : IGenericRepository<Actor>
{
    IEnumerable<Actor> GetActorsWithMovies();
    Actor Remove(int actorId);
    Actor GetByActorId(int actorId);
}
