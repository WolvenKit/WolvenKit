namespace WolvenKit.RED4.Types;

public partial class workWorkspotTree
{
    [RED("disableAutoAnimsetGeneraion")]
    public CBool DisableAutoAnimsetGeneraion
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}
