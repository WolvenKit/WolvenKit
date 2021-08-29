using System.IO;
using System.Runtime.InteropServices;

namespace WolvenKit.RED4.NewCR2W
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

        public CR2WExport Export { get; private set; }
        public string ImportPath { get; private set; } = "<failed to get import path>";
        public NewCR2WFile ParentFile { get; internal init; }

        #endregion Properties

        #region Methods

        public void SetChunkIndex(uint offset) => _embedded.chunkIndex = offset;

        //public void SetPathHash(ulong hash) => _embedded.pathHash = hash;
        public void SetImportIndex(uint idx) => _embedded.importIndex = idx;

        #endregion Methods
    }
}
