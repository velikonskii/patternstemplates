namespace Conversion;

public struct Digit
{
    private readonly byte _digit;

    public Digit(byte digit)
    {
        if (digit > 9)
        {
            throw new ArgumentOutOfRangeException(nameof(digit), "Digit cannot be greater than nine.");
        }
        _digit = digit; 
    }
    
    public static implicit operator byte(Digit d) 
        => d._digit; //implicit because conversion to byte is save
    public static explicit operator Digit(byte b) 
        => new (b);//explicit. We need to check whether value is in 0 to 9

    public override string ToString() => $"{_digit}";
    
}