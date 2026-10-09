namespace WolvenKit.RED4.Types;

/// <summary>Displays <see cref="CUInt64"/> values as depot paths.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public sealed class DisplayAsResourcePathAttribute : Attribute
{
    internal DisplayAsResourcePathAttribute()
    {
    }
}
