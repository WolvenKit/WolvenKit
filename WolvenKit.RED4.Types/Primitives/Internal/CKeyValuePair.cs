namespace WolvenKit.RED4.Types;

public sealed class CKeyValuePair : IRedType
{
    public CKeyValuePair(CName key, IRedType value)
    {
        Key = key;
        Value = value;
    }

    public CName Key { get; set; }
    public IRedType Value { get; set; }
}
