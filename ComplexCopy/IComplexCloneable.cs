namespace ComplexCopy;

public interface IComplexCloneable {}
public interface IComplexCloneable<out T> {}


public interface IDeepClone : IComplexCloneable
{
    object DeepClone();
}

public interface IDeepClone<out T> : IComplexCloneable<T>
{
    T DeepClone();
}

public interface IShallowClone<out T> : IComplexCloneable<T>
{
    T ShallowClone();
}