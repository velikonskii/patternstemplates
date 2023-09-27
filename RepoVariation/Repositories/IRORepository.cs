namespace RepoVariation.Repositories;

public interface IReadOnlyRepository<out T>
{
    T Get(string id);
    IEnumerable<T> GetAll();
}