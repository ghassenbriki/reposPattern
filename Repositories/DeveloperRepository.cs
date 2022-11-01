using reposPattern.Database;
using reposPattern.Entities;
using reposPattern.Interfaces;

namespace reposPattern.Repositories
{
    public class DeveloperRepository : GenericRepository<Developer>,IDeveloperRepository
    {
        
        public DeveloperRepository(ApplicationDbContext context) : base(context)
        {

        }
        public IEnumerable<Developer> GetPopularDevelopers(int count)
        {
            return _context.Developers.OrderByDescending(d => d.Followers).Take(count).ToList();
        }

       

        
    }
}
