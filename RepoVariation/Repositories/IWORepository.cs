namespace RepoVariation.Repositories;

public interface IWriteOnlyRepository<in T>
{
    void Insert(T item);
}