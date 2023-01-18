namespace WolvenKit.RED4.Types;

public enum EREDMetaInfo
{
    REDStruct,
    REDPrimitive,
    //REDComplex,
}

/// <summary>
/// Marks a field as serializable for redengine files.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class REDAttribute : Attribute
{
    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="REDAttribute"/> class.
    /// </summary>
    /// <param name="flags">
    /// Values needed for types such as <see cref="TDynArray{T}"/>, <see cref="Static{T}"/>, or <see cref="Array"/>.
    /// </param>
    public REDAttribute(params int[] flags)
    {
        Flags = flags;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="REDAttribute"/> class.
    /// </summary>
    /// <param name="name">
    /// Custom name to use in place of the default name.
    /// </param>
    /// <param name="flags">
    /// Values needed for types such as <see cref="TDynArray{T}"/>, <see cref="Static{T}"/>, or <see cref="Array"/>.
    /// </param>
    public REDAttribute(string name, params int[] flags)
    {
        Name = name;
        Flags = flags;
    }

    #endregion Constructors

    #region Properties

    public int[] Flags { get; private set; }
    public string Name { get; private set; }

    #endregion Properties

    #region Methods

    public override string ToString()
    {
        //return $"{Name} [{string.Join(",", Flags)}]";
        return $"{Name}";
    }

    #endregion Methods
}

/// <summary>
/// Marks a field as a compressed buffer for cr2w IO.
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public sealed class REDBufferAttribute : REDAttribute
{
    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="REDBufferAttribute"/> class.
    /// </summary>
    internal REDBufferAttribute(bool isIgnored = false)
    {
        IsIgnored = isIgnored;
    }

    #endregion Constructors

    #region Properties

    public bool IsIgnored { get; private set; }

    #endregion Properties

    #region Methods

    public override string ToString()
    {
        return String.Format($"{IsIgnored}");
    }

    #endregion Methods
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public sealed class REDClassAttribute : Attribute
{
    internal REDClassAttribute() { }

    public bool SerializeDefault { get; set; } = false;
    public int ChildLevel { get; set; } = 0;
}

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public sealed class REDPropertyAttribute : Attribute
{
    internal REDPropertyAttribute() { }

    public bool SerializeDefault { get; set; } = false;
    public bool IsIgnored { get; set; } = false;
}