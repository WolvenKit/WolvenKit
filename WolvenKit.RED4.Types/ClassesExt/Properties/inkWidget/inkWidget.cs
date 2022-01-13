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

    public string Path 
    {
        get { 
            if (GetParent() is inkWidget parent)
                return parent.Name + "/" + Name;
            return Name;

        }
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
