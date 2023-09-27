namespace RepoVariation.Entities;

public record Person(string Name) : IEntity
{
    public string Id => Name;
};