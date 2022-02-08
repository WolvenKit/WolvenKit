namespace WolvenKit.RED4.Types;

public partial class inkTextWidget
{
    [RED("aligmentConverted")]
    public CBool AligmentConverted
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}
