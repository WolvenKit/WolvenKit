using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zlib;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace WolvenKit.Cache
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
        public uint NameOffset;
        public uint Unk1; //?
        public ulong Unk2; //Null
        public uint Unk3; 
        public byte[] guid;
        public byte[] guid2;
        public ulong Comtype; //TODO: Investigate this. 2 = mesh, 3 = redcloth, 4 = redapex, 5 = reddest
        public byte[] Tail;

        List<byte> REDheader = new List<byte>();
        /*
         * RedEngine header in front of the compressed collision cache files with CSound Materials?
         * Uint32 unk1;
         * Uint32 unk2;
         * Uint32 unk3; //NULL
         * Uint32 itemcount;
         * ... dynamic number of items
         * 
         * Uint32 FileSize; // not always :(
         * byte unk9 ?
         */

        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(Bundle.FileName, FileMode.Open))
            using (var viewstream = file.CreateViewStream(PageOFfset, ZSize, MemoryMappedFileAccess.Read))
            {
                var zlib = new ZlibStream(viewstream, CompressionMode.Decompress);

                // get magic bytes
                var MAGIC = new byte[4];
                switch (Comtype)
                {
                    case 2:     // w2mesh: NXS mesh
                    case 5:     // reddest: NXS mesh
                        MAGIC = new byte[] { 0x4e, 0x58, 0x53 };
                        break;
                    case 3:     // redcloth: apb
                    case 4:     // redapex: apb
                        MAGIC = new byte[] { 0x5a, 0x5b, 0x5c, 0x5d };
                        break;
                    default:
                        break;
                }

                // seek magic bytes
                if (!(Comtype > 4 || Comtype == 1))
                {
                    Queue<byte> qBuffer = new Queue<byte>();

                    // auxiliary stream since zlibstreams don't support seeking.
                    using (MemoryStream ms = new MemoryStream())
                    {
                        zlib.CopyTo(ms);

                        var p = zlib.Position;
                        ms.Seek(0, SeekOrigin.Begin);
                        var testnumberofbytes = Math.Min(4096, ms.Length); // test only first max 4096 bytes

                        do
                        {
                            qBuffer.Enqueue(Convert.ToByte(ms.ReadByte()));
                            if (qBuffer.Count > MAGIC.Length)
                                qBuffer.Dequeue();
                            testnumberofbytes--;

                        } while (!Enumerable.SequenceEqual(qBuffer.ToArray(), MAGIC) && testnumberofbytes > 0);

                        // reposition stream
                        var fileBegin = 0;
                        if (testnumberofbytes > 0)
                            fileBegin = Math.Max(0, (int)ms.Position - MAGIC.Length);
                        ms.Seek(0, SeekOrigin.Begin);

                        // save header
                        var buffer = new byte[fileBegin];
                        ms.Read(buffer, 0, fileBegin);
                        REDheader.AddRange(buffer);

                        ms.CopyTo(output);
                    }
                }
                else
                {
                    zlib.CopyTo(output);
                }
            }
        }

        public string Extract(BundleFileExtractArgs e)
        {
            var filename = e.FileName;
            switch (Comtype)
            {
                case 2:
                case 5:
                    filename = Path.ChangeExtension(filename, "nxs"); 
                    break;
                case 3: 
                case 4: 
                    filename = Path.ChangeExtension(filename, "apb");
                    break;
                default:
                    break;
            }

            Directory.CreateDirectory(Path.GetDirectoryName(filename) ?? "");
            using (var output = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                Extract(output);
            }

            return filename;
        }
    }
}
