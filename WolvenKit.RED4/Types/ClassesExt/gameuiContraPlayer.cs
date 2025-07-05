namespace WolvenKit.RED4.Types;

public partial class gameuiContraPlayer : inkWidgetLogicController
{
    [RED("mass")]
    public CFloat Mass
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("jumpForce")]
    public CFloat JumpForce
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("movementSpeed")]
    public CFloat MovementSpeed
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    public gameuiContraPlayer()
    {
        PostConstruct();
    }

    partial void PostConstruct();
}