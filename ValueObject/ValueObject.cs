using System.Data.SqlTypes;
using System.Dynamic;

namespace ValueObject;


public class ValueObject<T> where T : new()
{

    private ValueObject(T value)
    {
        _value = value;
    }

    protected ValueObject<T> Create(T value)
    {
        return new ValueObject<T>(value);
    }

    private readonly T _value;
    
    
    public static bool EqualOperator(ValueObject<T> left, ValueObject<T> right)
    {
        if (ReferenceEquals(left, null) ^ ReferenceEquals(right, null))
        {
            return false;
        }
        return ReferenceEquals(left, right) || left.Equals(right);
    }
    
    public static bool NotEqualOperator(ValueObject<T> left, ValueObject<T> right)
    {
        return !(EqualOperator(left, right));
    }
    
    //protected IEnumerable<object> GetEqualityComponents();
    
    // public override bool Equals(object obj)
    // {
    //     if (obj == null || obj.GetType() != GetType())
    //     {
    //         return false;
    //     }
    //
    //     var other = (ValueObject)obj;
    //
    //     return this.GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    // }

    // public override int GetHashCode()
    // {
    //     return GetEqualityComponents()
    //         .Select(x => x != null ? x.GetHashCode() : 0)
    //         .Aggregate((x, y) => x ^ y);
    // }
    
    public static bool operator ==(ValueObject<T> one, ValueObject<T> two)
    {
        return EqualOperator(one, two);
    }
    
    public static bool operator !=(ValueObject<T> one, ValueObject<T> two)
    {
        return NotEqualOperator(one, two);
    }


    public static bool operator true(ValueObject<T> valueObject)
        => valueObject == default;

    public static bool operator false(ValueObject<T> valueObject)
        => valueObject != default;
    
    public static bool operator !(ValueObject<T> valueObject)
        => valueObject != default;
    
}