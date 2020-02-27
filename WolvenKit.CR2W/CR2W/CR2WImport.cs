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
        private CR2WImport _import;
        public CR2WImport Import {
            get => _import;
            set => _import = value;
        }

        public string DepotPathStr { get; set; }
        public string ClassNameStr { get; set; }


        public CR2WImportWrapper()
        {
            _import = new CR2WImport();
        }

        public CR2WImportWrapper(CR2WImport import)
        {
            _import = import;
        }

        public void SetOffset(uint offset) => _import.depotPath = offset;

        public override string ToString()
        {
            return DepotPathStr;
        }
    }
}