using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entity;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementation
{
    public class BiographyRepository : GenericRepository<Biography>, IBiographyRepository
    {
        readonly MovieManagementDbContext _dbContext;
        public BiographyRepository(MovieManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }

}
