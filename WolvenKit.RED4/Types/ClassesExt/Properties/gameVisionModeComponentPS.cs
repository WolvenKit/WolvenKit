namespace WolvenKit.RED4.Types;

public partial class gameVisionModeComponentPS
{
    [RED("questForcedModules")]
    public CArray<CName> QuestForcedModules
    {
        get => GetPropertyValue<CArray<CName>>();
        set => SetPropertyValue<CArray<CName>>(value);
    }

    [RED("questForcedMeshes")]
    public CArray<CName> QuestForcedMeshes
    {
        get => GetPropertyValue<CArray<CName>>();
        set => SetPropertyValue<CArray<CName>>(value);
    }
}
