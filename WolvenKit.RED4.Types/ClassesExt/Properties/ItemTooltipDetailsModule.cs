namespace WolvenKit.RED4.Types;

public partial class ItemTooltipDetailsModule
{
    [RED("modifierPowerLine")]
    public inkWidgetReference ModifierPowerLine
    {
        get => GetPropertyValue<inkWidgetReference>();
        set => SetPropertyValue<inkWidgetReference>(value);
    }

    [RED("modifierPowerLabel")]
    public inkTextWidgetReference ModifierPowerLabel
    {
        get => GetPropertyValue<inkTextWidgetReference>();
        set => SetPropertyValue<inkTextWidgetReference>(value);
    }

    [RED("modifierPowerWrapper")]
    public inkCompoundWidgetReference ModifierPowerWrapper
    {
        get => GetPropertyValue<inkCompoundWidgetReference>();
        set => SetPropertyValue<inkCompoundWidgetReference>(value);
    }
}
