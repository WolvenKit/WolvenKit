using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
        public uint ObjectsEnd { get; set; }
    }

    public class CR2WFile : Red4File, IDisposable
    {
        public const uint MAGIC = 0x57325243; // "W2RC"
        public const uint DEADBEEF = 0xDEADBEEF;


        public CR2WFileDebug Debug { get; } = new();
        public CR2WMetaData MetaData { get; } = new();


        public IReadOnlyList<IRedRef> Imports { get; }
        public IList<ICR2WProperty> Properties { get; }

        public IRedClass RootChunk { get; set; }

        //[Obsolete]
        public IList<IRedClass> Chunks { get; set; } = new List<IRedClass>();

        //[Obsolete]
        public IList<RedBuffer> Buffers { get; set; } = new List<RedBuffer>();

        public IList<ICR2WEmbeddedFile> EmbeddedFiles { get; }

        public CR2WFile()
        {
            Properties = new List<ICR2WProperty>();     //block 4
            EmbeddedFiles = new List<ICR2WEmbeddedFile>();       //block 7
        }

        
        #region IDisposable

        private bool _disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                }

                _disposed = true;
            }
        }

        ~CR2WFile()
        {
            Dispose(false);
        }

        #endregion
    }
}
