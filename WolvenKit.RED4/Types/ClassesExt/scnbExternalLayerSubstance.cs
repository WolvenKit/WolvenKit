namespace WolvenKit.RED4.Types;

public partial class scnbExternalLayerSubstance : RedBaseClass
{
    [RED("substance")]
    public CHandle<ISerializable> Substance
    {
        get => GetPropertyValue<CHandle<ISerializable>>();
        set => SetPropertyValue<CHandle<ISerializable>>(value);
    }

    public scnbExternalLayerSubstance()
    {
        PostConstruct();
    }

    partial void PostConstruct();
}