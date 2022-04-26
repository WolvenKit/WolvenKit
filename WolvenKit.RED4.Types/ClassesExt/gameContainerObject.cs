namespace WolvenKit.RED4.Types;

public class gameContainerObject : RedBaseClass
{
    [RED("lootID")]
    public TweakDBID LootID
    {
        get => GetPropertyValue<TweakDBID>();
        set => SetPropertyValue<TweakDBID>(value);
    }
}
