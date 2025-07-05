namespace WolvenKit.RED4.Types;

public partial class STextureGroupSetup
{
    [Ordinal(6)]
    [RED("alphaToCoverageThreshold")]
    public CUInt8 AlphaToCoverageThreshold
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }
}