namespace WolvenKit.RED4.Types;

public class SElevatorFloor : RedBaseClass
{
    [RED("floor")]
    public NodeRef Floor
    {
        get => GetPropertyValue<NodeRef>();
        set => SetPropertyValue<NodeRef>(value);
    }

    [RED("floorNum")]
    public CInt32 FloorNum
    {
        get => GetPropertyValue<CInt32>();
        set => SetPropertyValue<CInt32>(value);
    }

    [RED("marker")]
    public NodeRef Marker
    {
        get => GetPropertyValue<NodeRef>();
        set => SetPropertyValue<NodeRef>(value);
    }

    [RED("floorDisplayName")]
    public CString FloorDisplayName
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }
}
