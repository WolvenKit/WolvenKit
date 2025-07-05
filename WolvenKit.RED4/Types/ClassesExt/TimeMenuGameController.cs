namespace WolvenKit.RED4.Types;

public class TimeMenuGameController : inkIWidgetController
{
    [RED("selectorRef")]
    public inkWidgetReference SelectorRef
    {
        get => GetPropertyValue<inkWidgetReference>();
        set => SetPropertyValue<inkWidgetReference>(value);
    }

    [RED("applyBtn")]
    public inkWidgetReference ApplyBtn
    {
        get => GetPropertyValue<inkWidgetReference>();
        set => SetPropertyValue<inkWidgetReference>(value);
    }

    [RED("backBtn")]
    public inkWidgetReference BackBtn
    {
        get => GetPropertyValue<inkWidgetReference>();
        set => SetPropertyValue<inkWidgetReference>(value);
    }
}
