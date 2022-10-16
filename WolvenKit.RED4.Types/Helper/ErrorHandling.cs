using System;

namespace WolvenKit.RED4.Types;

public abstract class ParsingErrorEventArgs : EventArgs { }

public delegate bool ParsingErrorEventHandler(ParsingErrorEventArgs e);

public class InvalidRTTIEventArgs : ParsingErrorEventArgs
{
    public string PropertyName { get; }
    public Type ExpectedType { get; }
    public Type ActualType { get; }
    public IRedType Value { get; set; }

    public InvalidRTTIEventArgs(string propertyName, Type expectedType, Type actualType, IRedType value)
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
    public Enum Value { get; set; }

    public InvalidEnumValueEventArgs(Type enumType, string stringValue)
    {
        EnumType = enumType;
        StringValue = stringValue;

        Value = default;
    }
}
