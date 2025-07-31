namespace WolvenKit.RED4.Types;

public class InternalEnums
{
    [System.Flags]
    public enum EImportFlags
    {
        Default = 0x0,      // done / Load from same archive?
        Obligatory = 0x1,   // also sync in packages / not used in cr2w currently (1.61)
        Template = 0x2,     // done / not used in cr2w currently (1.61)
        Soft = 0x4,         // done / Load from any archive?
        Embedded = 0x8,     // Load from embedded file
        Inplace = 0x10,     // done / not used in cr2w currently (1.61)
    };

    [System.Flags]
    public enum EGroupTag
    {
        None = 0x0,
        Abstract = 0x1,
        NotQueryable = 0x2,
        CPO = 0x4,
        Debug = 0x8,
        DisabledContent = 0x10
    };
}
