using System.Collections.Generic;
using System.Diagnostics;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.CR2W
{
    public class CR2WFileDebug
    {
        public List<CName> Strings { get; set; }

        public CR2WNameInfo[] NameInfos { get; set; }
        public CR2WImportInfo[] ImportInfos { get; set; }
        public CR2WPropertyInfo[] PropertyInfos { get; set; }
        public CR2WExportInfo[] ChunkInfos { get; set; }
        public CR2WBufferInfo[] BufferInfos { get; set; }
        public CR2WEmbeddedInfo[] EmbeddedInfos { get; set; }
    }

    public class CR2WMetaData
    {
        public string FileName { get; set; }
        public uint Version { get; set; } = 195;
        public uint BuildVersion { get; set; } = 0;
        public EHashVersion HashVersion { get; set; }
    }

    public class CR2WFile : Red4File
    {
        public const uint MAGIC = 0x57325243; // "W2RC"
        public const uint DEADBEEF = 0xDEADBEEF;


        public CR2WFileDebug Debug { get; set; } = new();
        public CR2WMetaData MetaData { get; set; } = new();

        
        public IList<ICR2WProperty> Properties { get; }

        public IRedClass RootChunk => Chunks[0];

        public IList<IRedClass> Chunks
        {
            get => _chunks;
        }

        public IList<IRedBuffer> Buffers
        {
            get => _buffers;
        }

        public IList<ICR2WEmbeddedFile> EmbeddedFiles { get; }


        public CR2WFile()
        {
            Properties = new List<ICR2WProperty>();     //block 4
            EmbeddedFiles = new List<ICR2WEmbeddedFile>();       //block 7
        }
    }
}
