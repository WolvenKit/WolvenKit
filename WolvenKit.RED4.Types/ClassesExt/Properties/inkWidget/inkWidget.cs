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
        if (GetParent() is inkWidget parent)
            return parent.GetPath() + "/" + Name.GetValue();
        return Name.GetValue();
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
