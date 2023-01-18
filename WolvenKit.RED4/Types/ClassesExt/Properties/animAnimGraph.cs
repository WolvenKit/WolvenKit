namespace WolvenKit.RED4.Types;

public partial class animAnimGraph
{
    [Ordinal(999)]
    [RED("jsonFilesDirectory")]
    public CString JsonFilesDirectory
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }
}