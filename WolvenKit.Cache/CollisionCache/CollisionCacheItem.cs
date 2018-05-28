using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zlib;
using WolvenKit.Common;

namespace WolvenKit.Cache.CollisionCache
{
    /// <summary>
    /// Files packed into Collision.cache. Zlib compressed nxb/p3d file.
    /// </summary>
    public class CollisionCacheItem : IWitcherFile
    {
        public IWitcherArchiveType Bundle { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public uint ZSize { get; set; }
        public long PageOFfset { get; set; }
        public string CompressionType => "Zlib";

        public ulong Unk1; //NULL
        public ulong NameOffset;
        public ulong Unk2;
        public ulong Unk3;
        public ulong Unk4;
        public ulong Unk5;
        public ulong Unk6;
        public ulong Comtype; //TODO: Investigate this.


        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(Bundle.FileName, FileMode.Open))
            {
                using (var viewstream = file.CreateViewStream(PageOFfset, ZSize, MemoryMappedFileAccess.Read))
                {
                    var zlib = new ZlibStream(viewstream, CompressionMode.Decompress);
                    zlib.CopyTo(output);
                }
            }
        }

        public void Extract(string filename)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filename) ?? "");
            using (var output = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                Extract(output);
                output.Close();
            }
        }
    }
}
