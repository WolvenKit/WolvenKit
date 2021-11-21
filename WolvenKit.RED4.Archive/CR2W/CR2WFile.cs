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


        private IDictionary<IRedRef, int> _internalImports;
        public IReadOnlyList<IRedRef> Imports => new ReadOnlyCollection<IRedRef>(_internalImports.Keys.ToList());
        public IList<ICR2WProperty> Properties { get; }

        public IRedClass RootChunk => Chunks[0];

        public IList<IRedBuffer> Buffers
        {
            get => _buffers;
        }

        public IList<ICR2WEmbeddedFile> EmbeddedFiles { get; }

        public CR2WFile()
        {
            _internalImports = new Dictionary<IRedRef, int>();

            Properties = new List<ICR2WProperty>();     //block 4
            EmbeddedFiles = new List<ICR2WEmbeddedFile>();       //block 7

            RedBaseClass.RegisterEventHandler(typeof(CResourceReference<>), OnImport);
            RedBaseClass.RegisterEventHandler(typeof(CResourceAsyncReference<>), OnImport);
        }

        private void OnImport(object sender, RedBaseClass.ObjectChangedEventArgs e)
        {
            if (e.OldValue != null)
            {
                var oldValue = (IRedRef)e.OldValue;

                if (!_internalImports.ContainsKey(oldValue))
                {
                    throw new Exception();
                }

                _internalImports[oldValue]--;
                if (_internalImports[oldValue] == 0)
                {
                    _internalImports.Remove(oldValue);
                }
            }

            if (e.NewValue != null)
            {
                var newValue = (IRedRef)e.NewValue;

                if (!_internalImports.ContainsKey(newValue))
                {
                    _internalImports.Add(newValue, 0);
                }

                _internalImports[newValue]++;
            }
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
                    RedBaseClass.RemoveEventHandler(typeof(CResourceReference<>), OnImport);
                    RedBaseClass.RemoveEventHandler(typeof(CResourceAsyncReference<>), OnImport);
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
