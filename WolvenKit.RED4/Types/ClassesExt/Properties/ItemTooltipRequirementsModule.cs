namespace WolvenKit.RED4.Types;

public partial class ItemTooltipRequirementsModule
{
    [RED("allocationCostsWrapper")]
    public inkCompoundWidgetReference AllocationCostsWrapper
    {
        get => GetPropertyValue<inkCompoundWidgetReference>();
        set => SetPropertyValue<inkCompoundWidgetReference>(value);
    }
}
