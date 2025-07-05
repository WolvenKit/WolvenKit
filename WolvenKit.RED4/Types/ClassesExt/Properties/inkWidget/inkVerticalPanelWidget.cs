namespace WolvenKit.RED4.Types;

public partial class inkVerticalPanelWidget
{
    [RED("proxyWidget")]
    public CWeakHandle<inkWidget> ProxyWidget
    {
        get => GetPropertyValue<CWeakHandle<inkWidget>>();
        set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
    }
}
