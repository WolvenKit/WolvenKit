namespace WolvenKit.RED4.Types;

public class resResourceMetadata : CResource
{
    [Ordinal(0)]
    [RED("imageData")]
    public CArray<CUInt8> ImageData
    {
        get => GetPropertyValue<CArray<CUInt8>>();
        set => SetPropertyValue<CArray<CUInt8>>(value);
    }

    [Ordinal(1)]
    [RED("importData")]
    public CHandle<resResourceImportMetadata> ImportData
    {
        get => GetPropertyValue<CHandle<resResourceImportMetadata>>();
        set => SetPropertyValue<CHandle<resResourceImportMetadata>>(value);
    }
}