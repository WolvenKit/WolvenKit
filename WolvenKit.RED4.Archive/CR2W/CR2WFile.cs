using System.Collections.Generic;
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
        public CR2WChunkInfo[] ChunkInfos { get; set; }
        public CR2WBufferInfo[] BufferInfos { get; set; }
        public CR2WEmbeddedInfo[] EmbeddedInfos { get; set; }
    }

    public class CR2WFile
    {
        public const uint MAGIC = 0x57325243; // "W2RC"
        public const uint DEADBEEF = 0xDEADBEEF;

        public string FileName { get; set; }
        public uint Version { get; set; } = 195;
        public uint BuildVersion { get; set; } = 0;
        public EHashVersion HashVersion { get; set; }


        public IList<ICR2WProperty> Properties { get; }
        public IList<IRedClass> Chunks { get; }
        public IList<ICR2WBuffer> Buffers { get; }
        public IList<ICR2WEmbedded> Embedded { get; }

        public CR2WFileDebug Debug { get; set; } = new();

        public CR2WFile()
        {
            Properties = new List<ICR2WProperty>();     //block 4
            Chunks = new List<IRedClass>();             //block 5
            Buffers = new List<ICR2WBuffer>();          //block 6
            Embedded = new List<ICR2WEmbedded>();       //block 7
        }
    }
}
