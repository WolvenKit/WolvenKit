namespace WolvenKit.RED4.Types;

public partial class AreaEffectData
{
    [RED("None")]
    public NodeRef None
    {
        get => GetPropertyValue<NodeRef>();
        set => SetPropertyValue<NodeRef>(value);
    }
}