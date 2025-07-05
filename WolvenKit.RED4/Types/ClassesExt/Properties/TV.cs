namespace WolvenKit.RED4.Types;

public partial class TV
{
    [RED("channels")]
    public CArray<STvChannel> Channels
    {
        get => GetPropertyValue<CArray<STvChannel>>();
        set => SetPropertyValue<CArray<STvChannel>>(value);
    }

    [RED("securedText")]
    public CString SecuredText
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [RED("muteInterface")]
    public CBool MuteInterface
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}
