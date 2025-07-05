namespace WolvenKit.RED4.Types;

public partial class gameuiWardrobeSetPreviewGameController
{
    [RED("garmentSwitchEffectControllers")]
    public CArray<gameuiGarmentSwitchEffectController> GarmentSwitchEffectControllers
    {
        get => GetPropertyValue<CArray<gameuiGarmentSwitchEffectController>>();
        set => SetPropertyValue<CArray<gameuiGarmentSwitchEffectController>>(value);
    }
}
