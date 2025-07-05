namespace WolvenKit.RED4.Types;

public abstract class ParsingErrorEventArgs : EventArgs { }

public delegate bool ParsingErrorEventHandler(ParsingErrorEventArgs e);


public class InvalidRTTIEventArgs : ParsingErrorEventArgs
{
    public string PropertyName { get; }
    public string ExpectedType { get; }
    public string ActualType { get; }
    public IRedType? Value { get; set; }

    public InvalidRTTIEventArgs(string propertyName, string expectedType, string actualType, IRedType? value)
    {
        PropertyName = propertyName;
        ExpectedType = expectedType;
        ActualType = actualType;
        Value = value;
    }
}

public class InvalidDefaultValueEventArgs : ParsingErrorEventArgs
{

}

public class InvalidEnumValueEventArgs : ParsingErrorEventArgs
{
    public Type EnumType { get; }
    public string StringValue { get; }
    public Enum? Value { get; set; }

    public InvalidEnumValueEventArgs(Type enumType, string stringValue)
    {
        EnumType = enumType;
        StringValue = stringValue;

        Value = default;
    }
}

public class UnknownTypeEventArgs : ParsingErrorEventArgs
{
    public string RedName { get; }
    public RedTypeInfo Result { get; set; }

    public UnknownTypeEventArgs(string redName)
    {
        RedName = redName;
    }
}
