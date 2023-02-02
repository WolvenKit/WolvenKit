namespace WolvenKit.RED4.Types;

public partial class gameuiTimeskipGameController
{
    [RED("weatherIcon")]
    public inkImageWidgetReference WeatherIcon
    {
        get => GetPropertyValue<inkImageWidgetReference>();
        set => SetPropertyValue<inkImageWidgetReference>(value);
    }
}
