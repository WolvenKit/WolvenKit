namespace WolvenKit.RED4.Types;

public partial class gamedataItem_Record
{
    [RED("cpoItemCategory")]
    [REDProperty(IsIgnored = true)]
    public TweakDBID CpoItemCategory
    {
        get => GetPropertyValue<TweakDBID>();
        set => SetPropertyValue<TweakDBID>(value);
    }
}
