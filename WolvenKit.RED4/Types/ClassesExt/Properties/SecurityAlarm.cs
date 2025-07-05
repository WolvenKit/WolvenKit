namespace WolvenKit.RED4.Types;

public partial class SecurityAlarm
{
    [RED("isBlinkingSafe")]
    public CBool IsBlinkingSafe
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [RED("isBlinkingAlarmed")]
    public CBool IsBlinkingAlarmed
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [RED("blinkIntervalArmed")]
    public CFloat BlinkIntervalArmed
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("useSoundArmed")]
    public CBool UseSoundArmed
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}
