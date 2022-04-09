namespace WolvenKit.RED4.Types;

public class ElevatorDevice : RedBaseClass
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
