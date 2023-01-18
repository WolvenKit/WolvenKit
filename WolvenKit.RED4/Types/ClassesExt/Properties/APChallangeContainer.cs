namespace WolvenKit.RED4.Types;

public class APChallangeContainer : RedBaseClass
{
    [RED("contentScale")]
    public TweakDBID ContentScale
    {
        get => GetPropertyValue<TweakDBID>();
        set => SetPropertyValue<TweakDBID>(value);
    }
}