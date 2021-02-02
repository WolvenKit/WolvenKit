using System.IO;
using System.IO.MemoryMappedFiles;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace WolvenKit.Wwise
{
    public class SoundCacheItem : IGameFile
    {
        public IGameArchive Archive { get; set; }
        /// <summary>
        /// Name of the bundled item in the archive.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Name of the cache file this file is in. (Needed for Extracting the file)
        /// </summary>
        public string ParentFile;


        public long NameOffset;
        /// <summary>
        /// !!! Double check when writing !!! Some files use 64bit, older files may use 32bit.
        /// </summary>
        public long PageOffset { get; set; }
        public uint Size { get; set; }
        public uint ZSize { get; set; }

        public SoundCacheItem(IGameArchive Parent)
        {
            this.Archive = Parent;
        }

        public string CompressionType => "None";

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
    }
}
