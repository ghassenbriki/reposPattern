namespace reposPattern.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDeveloperRepository Developers { get; }
        IProjectRepository Projects { get; }

        int Complete();
    }
}
