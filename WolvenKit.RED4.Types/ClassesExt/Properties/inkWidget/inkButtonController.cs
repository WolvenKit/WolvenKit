namespace WolvenKit.RED4.Types;

public partial class inkButtonController
{
    [RED("shouldUpdateScrollController")]
    public CBool ShouldUpdateScrollController
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [RED("isNavigalbe")]
    public CBool IsNavigalbe
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}
