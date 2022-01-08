namespace WolvenKit.RED4.Types;

public partial class scannerBorderGameController
{
    [OrdinalOverride(Before = 20)]
    [RED("insideCrosshair")]
    public inkCompoundWidgetReference InsideCrosshair
    {
        get => GetPropertyValue<inkCompoundWidgetReference>();
        set => SetPropertyValue<inkCompoundWidgetReference>(value);
    }

    [OrdinalOverride(Before = 23)]
    [RED("DeviceFluff1")]
    public inkCanvasWidgetReference DeviceFluff1
    {
        get => GetPropertyValue<inkCanvasWidgetReference>();
        set => SetPropertyValue<inkCanvasWidgetReference>(value);
    }

    [OrdinalOverride(Before = 23)]
    [RED("DeviceFluff2")]
    public inkCanvasWidgetReference DeviceFluff2
    {
        get => GetPropertyValue<inkCanvasWidgetReference>();
        set => SetPropertyValue<inkCanvasWidgetReference>(value);
    }

    [OrdinalOverride(Before = 23)]
    [RED("DeviceFluff3")]
    public inkCanvasWidgetReference DeviceFluff3
    {
        get => GetPropertyValue<inkCanvasWidgetReference>();
        set => SetPropertyValue<inkCanvasWidgetReference>(value);
    }

    [OrdinalOverride(Before = 23)]
    [RED("DeviceFluff4")]
    public inkFlexWidgetReference DeviceFluff4
    {
        get => GetPropertyValue<inkFlexWidgetReference>();
        set => SetPropertyValue<inkFlexWidgetReference>(value);
    }

    [OrdinalOverride(Before = 23)]
    [RED("DeviceFluff5")]
    public inkFlexWidgetReference DeviceFluff5
    {
        get => GetPropertyValue<inkFlexWidgetReference>();
        set => SetPropertyValue<inkFlexWidgetReference>(value);
    }

    [OrdinalOverride(Before = 23)]
    [RED("DeviceFluff6")]
    public inkHorizontalPanelWidgetReference DeviceFluff6
    {
        get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
        set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
    }

    [OrdinalOverride(Before = 23)]
    [RED("DeviceFluff7")]
    public inkImageWidgetReference DeviceFluff7
    {
        get => GetPropertyValue<inkImageWidgetReference>();
        set => SetPropertyValue<inkImageWidgetReference>(value);
    }
}
