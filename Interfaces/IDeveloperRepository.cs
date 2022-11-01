using reposPattern.Entities;

namespace reposPattern.Interfaces
{
    public interface IDeveloperRepository : IGenericRepository<Developer>
    {
        IEnumerable<Developer> GetPopularDevelopers(int count);

    }
}
