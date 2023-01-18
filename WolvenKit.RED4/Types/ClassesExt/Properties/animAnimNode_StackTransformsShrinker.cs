namespace WolvenKit.RED4.Types;

public partial class animAnimNode_StackTransformsShrinker
{
    [Ordinal(999)]
    [RED("extenderNodeId")]
    public CUInt32 ExtenderNodeId
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }
}