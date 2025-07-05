namespace WolvenKit.RED4.Types;

// Probably Device or InteractiveDevice
public class ElevatorDevice : entEntity
{
    [RED("elevatorSpeed")]
    public CFloat ElevatorSpeed
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("floors")]
    public CArray<SElevatorFloor> Floors
    {
        get => GetPropertyValue<CArray<SElevatorFloor>>();
        set => SetPropertyValue<CArray<SElevatorFloor>>(value);
    }
}
