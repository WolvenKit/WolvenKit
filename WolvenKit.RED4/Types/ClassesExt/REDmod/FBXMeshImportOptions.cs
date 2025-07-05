namespace WolvenKit.RED4.Types;

public class FBXMeshImportOptions : ResourceImportOptions
{
    [Ordinal(0)]
    [RED("resourcePath")]
    public CString ResourcePath
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(1)]
    [RED("sourcePath")]
    public CString SourcePath
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(1)]
    [RED("generateCollisionIfMissing")]
    public CBool GenerateCollisionIfMissing
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}