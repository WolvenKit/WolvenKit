namespace WolvenKit.RED4.Types;

public partial class meshMeshMaterialBuffer
{
    [RED("materials")]
    [REDProperty(IsIgnored = true)]
    public CArray<IMaterial> Materials
    {
        get => GetPropertyValue<CArray<IMaterial>>();
        set => SetPropertyValue(value);
    }

    partial void PostConstruct()
    {
        Materials = new CArray<IMaterial>();
    }
}