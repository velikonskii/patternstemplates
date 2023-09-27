using RepoVariation.Entities;

namespace RepoVariation.Repositories;

class ListRepository<T> : IRepository<T> where T : IEntity
{
    private List<T> _entities = new List<T>();
    
    public void Insert(T item)
    {
        _entities.Add(item);
    }

    public T Get(string id)
    {
        return _entities.FirstOrDefault(q => q.Id == id)!;
    }

    public IEnumerable<T> GetAll()
    {
        return _entities;
    }
}