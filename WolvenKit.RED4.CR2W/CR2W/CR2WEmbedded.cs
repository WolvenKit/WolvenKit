using System.IO;
using System.Runtime.InteropServices;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED4.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct CR2WEmbedded
    {
        [FieldOffset(0)]
        public uint importIndex;        // updated on cr2w write

        [FieldOffset(4)]
        public uint chunkIndex;               // updated on cr2w write

        [FieldOffset(8)]
        public ulong pathHash;          // updated on cr2w write // always 0 in cp77?
    }

    public class CR2WEmbeddedWrapper : ICR2WEmbedded
    {
        #region Fields

        private CR2WEmbedded _embedded;

        #endregion Fields

        #region Constructors

        public CR2WEmbeddedWrapper()
        {
            _embedded = new CR2WEmbedded();
        }

        public CR2WEmbeddedWrapper(CR2WEmbedded embedded)
        {
            _embedded = embedded;
        }

        #endregion Constructors

        #region Properties

        public CR2WEmbedded Embedded
        {
            get => _embedded;
            set => _embedded = value;
        }

        public ICR2WExport Export { get; private set; }
        public string ImportPath { get; private set; } = "<failed to get import path>";
        public CR2WFile ParentFile { get; internal init; }

        #endregion Properties

        #region Methods

        public void ReadData(BinaryReader file)
        {
            ImportPath = ParentFile.Imports[(int)Embedded.importIndex - 1].DepotPathStr;
            Export = ParentFile.Chunks[(int)Embedded.chunkIndex];
        }

        public void SetChunkIndex(uint offset) => _embedded.chunkIndex = offset;

        //public void SetPathHash(ulong hash) => _embedded.pathHash = hash;
        public void SetImportIndex(uint idx) => _embedded.importIndex = idx;

        public override string ToString()
        {
            return $"{Export.ChunkIndex}:{ImportPath}";
        }

        #endregion Methods
    }
}
