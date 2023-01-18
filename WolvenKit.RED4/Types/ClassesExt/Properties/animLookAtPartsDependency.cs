namespace WolvenKit.RED4.Types;

public partial class animLookAtPartsDependency
{
    [Ordinal(998)]
    [RED("innerSquareColor")]
    public CColor InnerSquareColor
    {
        get => GetPropertyValue<CColor>();
        set => SetPropertyValue<CColor>(value);
    }

    [Ordinal(999)]
    [RED("outerSquareColor")]
    public CColor OuterSquareColor
    {
        get => GetPropertyValue<CColor>();
        set => SetPropertyValue<CColor>(value);
    }

    partial void PostConstruct()
    {
        InnerSquareColor = new();
        OuterSquareColor = new();
    }
}