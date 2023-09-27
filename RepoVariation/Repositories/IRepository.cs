using RepoVariation.Entities;

namespace RepoVariation.Repositories;

public interface IRepository<T> 
    : IWriteOnlyRepository<T>, IReadOnlyRepository<T> 
    where T 
    : IEntity
{
}