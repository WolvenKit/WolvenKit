namespace WolvenKit.RED4.Types;

public partial class TV
{
    [RED("channels")]
    public CArray<STvChannel> Channels
    {
        get => GetPropertyValue<CArray<STvChannel>>();
        set => SetPropertyValue<CArray<STvChannel>>(value);
    }
}
