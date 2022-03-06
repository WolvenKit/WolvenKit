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

    public string GetPath()
    {
        if (GetParent() is { } parent)
        {
            return parent.GetPath() + "/" + Name;
        }

        return Name;
    }

    public inkWidget GetParent()
    {
        if (ParentWidget != null)
        {
            return (inkWidget)ParentWidget.GetValue();
        }
        return null;
    }
}
