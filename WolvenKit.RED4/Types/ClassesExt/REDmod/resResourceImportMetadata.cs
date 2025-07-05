namespace WolvenKit.RED4.Types;

public class resResourceImportMetadata : RedBaseClass
{
    [Ordinal(0)]
    [RED("importOptions")]
    public CHandle<ResourceImportOptions> ImportOptions
    {
        get => GetPropertyValue<CHandle<ResourceImportOptions>>();
        set => SetPropertyValue<CHandle<ResourceImportOptions>>(value);
    }
}