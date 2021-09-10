using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace WolvenKit.RED4.Archive.CR2W
{
    /// <summary>
    ///
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct CR2WImportInfo
    {
        [FieldOffset(0)]
        public uint offset;

        [FieldOffset(4)]
        public ushort className;

        [FieldOffset(6)]
        public ushort flags;
    }

    public class CR2WImport : ICR2WImport
    {
        public string DepotPath { get; set; }
        public string ClassName { get; set; }
        public ushort Flags { get; set; }
    }
}
