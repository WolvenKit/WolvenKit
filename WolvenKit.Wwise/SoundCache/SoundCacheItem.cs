using System.IO;
using System.IO.MemoryMappedFiles;
using WolvenKit.Interfaces;

namespace WolvenKit.Wwise.SoundCache
{
    public class SoundCacheItem : IWitcherFile
    {
        public IWitcherArchiveType Bundle { get; set; }
        /// <summary>
        /// Name of the bundled item in the archive.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Name of the cache file this file is in. (Needed for Extracting the file)
        /// </summary>
        public string ParentFile;


        public long NameOffset;
        public long Offset { get; set; }
        public long Size { get; set; }
        public uint ZSize { get; set; }

        public SoundCacheItem(IWitcherArchiveType Parent)
        {
            this.Bundle = Parent;
        }

        public string CompressionType => "None";

        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(this.ParentFile, FileMode.Open))
            {
                using (var viewstream = file.CreateViewStream(Offset, Size, MemoryMappedFileAccess.Read))
                {
                    viewstream.CopyTo(output);
                }
            }
        }

        public void Extract(string filename)
        {
            using (var output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write))
            {
                Extract(output);
                output.Close();
            }
        }
    }
}
