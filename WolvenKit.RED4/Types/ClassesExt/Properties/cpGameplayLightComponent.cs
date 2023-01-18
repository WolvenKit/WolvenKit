namespace WolvenKit.RED4.Types;

public partial class cpGameplayLightComponent
{
    [OrdinalOverride(Before = 9)]
    [RED("placedEditorData")]
    public new CHandle<entIPlacedComponentEditorData> PlacedEditorData
    {
        get => GetPropertyValue<CHandle<entIPlacedComponentEditorData>>();
        set => SetPropertyValue<CHandle<entIPlacedComponentEditorData>>(value);
    }
}