using System.IO;
using System.Runtime.InteropServices;

namespace WolvenKit.CR2W
{
    /// IMPORT FLAGS
    [System.Flags]
    public enum EImportFlags
    {
        Default = 0x0,      // done
        Obligatory = 0x1,   
        Template = 0x2,     // done
        Soft = 0x4,         // done
        HashedPath = 0x8,       
        Inplace = 0x10,     // done
    };



    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct CR2WImport
    {
        [FieldOffset(0)]
        public uint depotPath;

        [FieldOffset(4)]
        public ushort className;

        [FieldOffset(6)]
        public ushort flags;
    }

    
}