using System.IO;
using System.IO.MemoryMappedFiles;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.Wwise
{
    public class SoundCacheItem : IGameFile
    {
        #region Fields

        public long NameOffset;

        /// <summary>
        /// Name of the cache file this file is in. (Needed for Extracting the file)
        /// </summary>
        public string ParentFile;

        #endregion Fields

        #region Constructors

        public SoundCacheItem(IGameArchive Parent)
        {
            this.Archive = Parent;
        }

        #endregion Constructors

        #region Properties

        public ulong Key => FNV1A64HashAlgorithm.HashString(Name);
        public IGameArchive Archive { get; set; }
        public string CompressionType => "None";

        public string ArchiveName { get; set; }

        /// <summary>
        /// Name of the bundled item in the archive.
        /// </summary>
        public string Name { get; set; }

        public string Extension => Path.GetExtension(Name);

        /// <summary>
        /// !!! Double check when writing !!! Some files use 64bit, older files may use 32bit.
        /// </summary>
        public long PageOffset { get; set; }

        public uint Size { get; set; }
        public uint ZSize { get; set; }

        #endregion Properties

        #region Methods

        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(this.ParentFile, FileMode.Open))
            {
                using (var viewstream = file.CreateViewStream(PageOffset, Size, MemoryMappedFileAccess.Read))
                {
                    viewstream.CopyTo(output);
                }
            }
        }

        #endregion Methods
    }
}
