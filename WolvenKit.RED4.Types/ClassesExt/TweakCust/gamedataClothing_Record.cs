namespace WolvenKit.RED4.Types;

public partial class gamedataClothing_Record
{
    [RED("scaleToPlayer")]
    [REDProperty(IsIgnored = true)]
    public CBool ScaleToPlayer
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}
