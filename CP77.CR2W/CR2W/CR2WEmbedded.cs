using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Linq;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace CP77.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct CR2WEmbedded
    {
        [FieldOffset(0)]
        public uint importIndex;        // updated on cr2w write

        [FieldOffset(4)]
        public uint chunkIndex;               // updated on cr2w write

        [FieldOffset(8)]
        public ulong pathHash;          // updated on cr2w write
    }

    public class CR2WEmbeddedWrapper
    {
        public CR2WEmbeddedWrapper()
        {
            _embedded = new CR2WEmbedded();
        }

        public CR2WEmbeddedWrapper(CR2WEmbedded embedded)
        {
            _embedded = embedded;
        }

        public CR2WFile ParentFile { get; internal init; }
        private CR2WEmbedded _embedded;
        public CR2WEmbedded Embedded
        {
            get => _embedded;
            set => _embedded = value;
        }

        public string ImportPath { get; private set; } = "<failed to get import path>";
        public CR2WExportWrapper Export { get; private set; }


        public void SetChunkIndex(uint offset) => _embedded.chunkIndex = offset;
        //public void SetPathHash(ulong hash) => _embedded.pathHash = hash;
        public void SetImportIndex(uint idx) => _embedded.importIndex = idx;

        public void ReadData(BinaryReader file)
        {
            ImportPath = ParentFile.Imports[(int)Embedded.importIndex - 1].DepotPathStr;
            Export = ParentFile.Chunks[(int)Embedded.chunkIndex];
        }

        public override string ToString()
        {
            return $"{Export.ChunkIndex}:{ImportPath}";
        }
    }
}