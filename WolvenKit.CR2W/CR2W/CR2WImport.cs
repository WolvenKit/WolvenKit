using System.IO;
using System.Runtime.InteropServices;

namespace WolvenKit.CR2W
{
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

    public class CR2WImportWrapper
    {
        public CR2WImport Import { get; set; }

        private readonly CR2WFile _cr2w;

        public string DepotPathStr => _cr2w.StringDictionary[Import.depotPath];
        public string ClassNameStr => _cr2w.names[Import.className].Str;
        public ushort Flags => Import.flags;

        public CR2WImportWrapper(CR2WImport import, CR2WFile cr2w)
        {
            Import = import;
            _cr2w = cr2w;
        }

        public override string ToString() => DepotPathStr;
    }
}