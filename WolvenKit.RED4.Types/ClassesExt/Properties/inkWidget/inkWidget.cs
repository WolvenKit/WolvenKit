namespace WolvenKit.RED4.Types;

public partial class inkWidget
{
    [OrdinalOverride(After = 19)]
    [RED("backendData")]
    public CHandle<inkWidgetBackendData> BackendData
    {
        get => GetPropertyValue<CHandle<inkWidgetBackendData>>();
        set => SetPropertyValue<CHandle<inkWidgetBackendData>>(value);
    }
}
