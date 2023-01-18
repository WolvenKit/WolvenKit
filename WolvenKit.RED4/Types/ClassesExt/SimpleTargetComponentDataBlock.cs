namespace WolvenKit.RED4.Types;

public class SimpleTargetComponentDataBlock : RedBaseClass
{
    [RED("persistentState")]
    public CHandle<gamePersistentState> PersistentState
    {
        get => GetPropertyValue<CHandle<gamePersistentState>>();
        set => SetPropertyValue<CHandle<gamePersistentState>>(value);
    }
}