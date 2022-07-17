namespace WolvenKit.RED4.Types;

public partial class gamedataStatusEffect_Record
{
    [RED("debugTags")]
    [REDProperty(IsIgnored = true)]
    public CArray<CName> DebugTags
    {
        get => GetPropertyValue<CArray<CName>>();
        set => SetPropertyValue<CArray<CName>>(value);
    }
}
