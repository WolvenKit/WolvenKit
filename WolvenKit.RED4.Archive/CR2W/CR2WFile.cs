using System;
using System.Collections.Generic;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.CR2W
{
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


        public CR2WFileInfo Info { get; internal set; }
        public CR2WMetaData MetaData { get; } = new();


        public IReadOnlyList<IRedRef> Imports { get; }
        public IList<ICR2WProperty> Properties { get; }

        public RedBaseClass RootChunk { get; set; }

        public IList<ICR2WEmbeddedFile> EmbeddedFiles { get; }

        public CR2WFile()
        {
            Properties = new List<ICR2WProperty>();     //block 4
            EmbeddedFiles = new List<ICR2WEmbeddedFile>();       //block 7
        }

        #region Events

        public event ObjectChangedEventHandler ObjectChanged;

        public void AttachEventHandler()
        {
            RootChunk.ObjectChanged += OnObjectChanged;

            foreach (var embeddedFile in EmbeddedFiles)
            {
                embeddedFile.Content.ObjectChanged += OnObjectChanged;
            }
        }

        private void OnObjectChanged(object sender, ObjectChangedEventArgs e)
        {
            
        }

        #endregion

        #region Methods

        public List<string> FindType(Type type)
        {
            var result = new List<string>();

            result.AddRange(((RedBaseClass)RootChunk).FindType(type));

            for (int i = 0; i < EmbeddedFiles.Count; i++)
            {
                result.AddRange(((RedBaseClass)EmbeddedFiles[i].Content).FindType(type, $"emb{i}"));
            }

            return result;
        }

        public (bool, object) GetFromXPath(string xPath)
        {
            var parts = xPath.Split('.');

            if (parts[0] == "root")
            {
                return ((RedBaseClass)RootChunk).GetFromXPath(parts[1..]);
            }

            if (parts[0].StartsWith("emb"))
            {
                if (int.TryParse(parts[0][3..], out var index))
                {
                    return ((RedBaseClass)EmbeddedFiles[index].Content).GetFromXPath(parts[1..]);
                }
            }

            return (false, null);
        }

        #endregion Methods

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
