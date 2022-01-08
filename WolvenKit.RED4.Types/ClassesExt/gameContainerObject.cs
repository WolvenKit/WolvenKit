namespace WolvenKit.RED4.Types;

[REDMeta]
public class gameContainerObject : RedBaseClass
{
    [RED("lootID")]
    public TweakDBID LootID
    {
        get => GetPropertyValue<TweakDBID>();
        set => SetPropertyValue<TweakDBID>(value);
    }
}
