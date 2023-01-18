namespace WolvenKit.RED4.Types;

// Probably gameContainerObjectBase
public class gameContainerObject : entEntity
{
    [RED("lootID")]
    public TweakDBID LootID
    {
        get => GetPropertyValue<TweakDBID>();
        set => SetPropertyValue<TweakDBID>(value);
    }
}
