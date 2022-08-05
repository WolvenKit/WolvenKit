namespace WolvenKit.RED4.Types;

public partial class gamedataItemAction_Record
{
    [RED("journalEntry")]
    [REDProperty(IsIgnored = true)]
    public CString JournalEntry
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }
}
