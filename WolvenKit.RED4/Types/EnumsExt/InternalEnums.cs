namespace WolvenKit.RED4.Types;

public class InternalEnums
{
    [System.Flags]
    public enum EImportFlags
    {
        Default = 0x0,      // done
        Obligatory = 0x1,   // also sync in packages
        Template = 0x2,     // done
        Soft = 0x4,         // done
        Embedded = 0x8,
        Inplace = 0x10,     // done
    };
}