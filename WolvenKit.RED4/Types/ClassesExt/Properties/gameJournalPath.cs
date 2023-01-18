namespace WolvenKit.RED4.Types;

public partial class gameJournalPath
{
    [OrdinalOverride(After = 0)]
    [RED("editorPath")]
    public CString EditorPath
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }
}