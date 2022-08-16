namespace WolvenKit.RED4.Types;

public partial class gamedataCharacter_Record
{
    [RED("cpoCharacterBuild")]
    [REDProperty(IsIgnored = true)]
    public CString CpoCharacterBuild
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [RED("cpoClassName")]
    [REDProperty(IsIgnored = true)]
    public CName CpoClassName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }
}
