namespace WolvenKit.RED4.Types;

public partial class WindowBlinders
{
    [RED("doorType")]
    public CEnum<Enums.EDoorType> DoorType
    {
        get => GetPropertyValue<CEnum<Enums.EDoorType>>();
        set => SetPropertyValue<CEnum<Enums.EDoorType>>(value);
    }

    [RED("initialStatus")]
    public CEnum<Enums.EDoorStatus> InitialStatus
    {
        get => GetPropertyValue<CEnum<Enums.EDoorStatus>>();
        set => SetPropertyValue<CEnum<Enums.EDoorStatus>>(value);
    }
}