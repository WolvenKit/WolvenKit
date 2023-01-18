namespace WolvenKit.RED4.Types;

public class entIPlacedComponentEditorData : RedBaseClass
{
    [Ordinal(0)]
    [RED("initialTransform")]
    public Transform InitialTransform
    {
        get => GetPropertyValue<Transform>();
        set => SetPropertyValue<Transform>(value);
    }
}