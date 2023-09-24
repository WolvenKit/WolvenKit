namespace WolvenKit.RED4.Types;

public partial class RipperdocIdPanel : inkWidgetLogicController
{
    [RED("fluffContainer")]
    public inkWidgetReference FluffContainer
    {
        get => GetPropertyValue<inkWidgetReference>();
        set => SetPropertyValue<inkWidgetReference>(value);
    }

    [RED("nameLabel")]
    public inkTextWidgetReference NameLabel
    {
        get => GetPropertyValue<inkTextWidgetReference>();
        set => SetPropertyValue<inkTextWidgetReference>(value);
    }

    [RED("moneyLabel")]
    public inkTextWidgetReference MoneyLabel
    {
        get => GetPropertyValue<inkTextWidgetReference>();
        set => SetPropertyValue<inkTextWidgetReference>(value);
    }

    public RipperdocIdPanel()
    {
        PostConstruct();
    }

    partial void PostConstruct();
}