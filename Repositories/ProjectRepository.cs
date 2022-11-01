using reposPattern.Database;
using reposPattern.Entities;
using reposPattern.Interfaces;

namespace reposPattern.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
