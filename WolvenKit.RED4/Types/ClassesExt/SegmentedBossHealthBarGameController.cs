namespace WolvenKit.RED4.Types;

public partial class SegmentedBossHealthBarGameController : inkIWidgetController
{
    [RED("healthPersentage")]
    public inkTextWidgetReference HealthPersentage
    {
        get => GetPropertyValue<inkTextWidgetReference>();
        set => SetPropertyValue<inkTextWidgetReference>(value);
    }

    [RED("bossName")]
    public inkTextWidgetReference BossName
    {
        get => GetPropertyValue<inkTextWidgetReference>();
        set => SetPropertyValue<inkTextWidgetReference>(value);
    }

    [RED("leftHealthControllerRef")]
    public inkCompoundWidgetReference LeftHealthControllerRef
    {
        get => GetPropertyValue<inkCompoundWidgetReference>();
        set => SetPropertyValue<inkCompoundWidgetReference>(value);
    }

    [RED("middleHealthControllerRef")]
    public inkCompoundWidgetReference MiddleHealthControllerRef
    {
        get => GetPropertyValue<inkCompoundWidgetReference>();
        set => SetPropertyValue<inkCompoundWidgetReference>(value);
    }

    [RED("rightHealthControllerRef")]
    public inkCompoundWidgetReference RightHealthControllerRef
    {
        get => GetPropertyValue<inkCompoundWidgetReference>();
        set => SetPropertyValue<inkCompoundWidgetReference>(value);
    }

    public SegmentedBossHealthBarGameController()
    {
        PostConstruct();
    }

    partial void PostConstruct();
}