namespace WolvenKit.RED4.Types;

public partial class CyberwareItemLogicController : inkWidgetLogicController
{
    [RED("slotRoot")]
    public inkCompoundWidgetReference SlotRoot
    {
        get => GetPropertyValue<inkCompoundWidgetReference>();
        set => SetPropertyValue<inkCompoundWidgetReference>(value);
    }

    public CyberwareItemLogicController()
    {
        PostConstruct();
    }

    partial void PostConstruct();
}