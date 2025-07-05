namespace WolvenKit.RED4.Types;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class OrdinalAttribute : Attribute
{
    internal OrdinalAttribute(ushort ordinal)
    {
        Ordinal = ordinal;
    }

    public ushort Ordinal { get; private set; }
}

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class OrdinalOverrideAttribute : Attribute
{
    internal OrdinalOverrideAttribute() { }

    public short Before { get; set; } = -1;
    public short After { get; set; } = -1;
}