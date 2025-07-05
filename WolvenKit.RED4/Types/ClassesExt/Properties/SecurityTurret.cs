namespace WolvenKit.RED4.Types;

public partial class SecurityTurret
{
    [RED("TargetDataBlock")]
    public SimpleTargetComponentDataBlock TargetDataBlock
    {
        get => GetPropertyValue<SimpleTargetComponentDataBlock>();
        set => SetPropertyValue<SimpleTargetComponentDataBlock>(value);
    }
}