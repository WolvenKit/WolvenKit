using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using Catel.IoC;
using CP77.Common.Services;
using CP77.Common.Tools;
using CP77.Common.Tools.FNV1A;
using CP77.CR2W.Archive;
using CP77Tools.Model;
using RED.CRC32;

namespace CP77.CR2W
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public static partial class ModTools
    {
        
        /// <summary>
        /// Creates and archive from a folder and packs all files inside into it
        /// </summary>
        /// <param name="infolder"></param>
        /// <param name="outpath"></param>
        /// <returns></returns>
        public static Archive.Archive Pack(DirectoryInfo infolder, DirectoryInfo outpath)
        {
            if (!infolder.Exists) return null;
            if (!outpath.Exists) return null;
            
            var outfile = Path.Combine(outpath.FullName, $"basegame_{infolder.Name}.archive");
            var ar = new Archive.Archive
            {
                Filepath = outfile,
                Table = new ArTable()
            };
            using var fs = new FileStream(outfile, FileMode.Create);
            using var bw = new BinaryWriter(fs);

            #region write header
            
            ar.Header.Write(bw);
            bw.Write(new byte[132]); // some weird padding
            
            #endregion

            #region write files

            var exludedExtensions = new[]
            {
                ".buffer",
                ".dds",
                ".DS_Store", //Hooray for OSX
            };
            var allfiles = infolder.GetFiles("*", SearchOption.AllDirectories);
            var parentfiles = allfiles
                .Where(_ => exludedExtensions.All(x => _.Extension != x));
            var fileInfos = parentfiles
                .OrderBy(_ => FNV1A64HashAlgorithm.HashString(GetRelpath(_)))
                .ToList();

            string GetRelpath(FileInfo infi) => infi.FullName[(infolder.FullName.Length + 1)..];

            Logger.LogString($"Found {fileInfos.Count} bundle entries to pack.", Logtype.Important);
            
            Thread.Sleep(1000);
            int progress = 0;
            Logger.LogProgress(0);
            foreach (var fileInfo in fileInfos)
            {
                var relpath = GetRelpath(fileInfo);
                var hash = FNV1A64HashAlgorithm.HashString(relpath);
                if (fileInfo.Extension == ".bin")
                    hash = ulong.Parse(Path.GetFileNameWithoutExtension(relpath));

                using var fileStream = new FileStream(fileInfo.FullName, FileMode.Open);
                using var fileBinaryReader = new BinaryReader(fileStream);

                // fileinfo data
                uint firstimportidx = (uint)ar.Table.Dependencies.Count;
                uint lastimportidx = (uint)ar.Table.Dependencies.Count;
                uint firstoffsetidx = (uint)ar.Table.Offsets.Count;
                uint lastoffsetidx = (uint)ar.Table.Offsets.Count;
                int flags = 0;
                
                var cr2w = TryReadCr2WFile(fileBinaryReader);
                if (cr2w != null)
                {
                    //register imports
                    foreach (var cr2WImportWrapper in cr2w.Imports)
                    {
                        if (!ar.Table.Dependencies.Select(_ => _.HashStr).Contains(cr2WImportWrapper.DepotPathStr))
                            ar.Table.Dependencies.Add(
                                new HashEntry(FNV1A64HashAlgorithm.HashString(cr2WImportWrapper.DepotPathStr)));
                    }
                    lastimportidx = (uint)ar.Table.Dependencies.Count;
                    
                    // kraken the file and write
                    var cr2wfilesize = (int)cr2w.Header.fileSize;
                    fileBinaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    var cr2winbuffer = fileBinaryReader.ReadBytes(cr2wfilesize);
                    var offset = bw.BaseStream.Position;
                    
                    var (zsize, crc) = bw.CompressAndWrite(cr2winbuffer);
                    ar.Table.Offsets.Add(new OffsetEntry(
                        (ulong) offset, 
                        zsize,
                        (uint) cr2winbuffer.Length));
                    
                    // TODO: each cr2w needs to have the buffer already kraken'd
                    // foreach buffer write
                    var bufferOffsets = cr2w.Buffers.Select(_ => _.Buffer);
                    foreach (var buffer in bufferOffsets)
                    {
                        var bsize = buffer.memSize;
                        var bzsize = buffer.diskSize;  //compressed size of the buffer inside the cr2wfile
                        fileBinaryReader.BaseStream.Seek(buffer.offset, SeekOrigin.Begin);
                        var b = fileBinaryReader.ReadBytes((int)bzsize);   //read bzsize bytes from the cr2w
                        var boffset = bw.BaseStream.Position;
                        
                        bw.Write(b);
                        ar.Table.Offsets.Add(new OffsetEntry(
                            (ulong)boffset,
                            bzsize,
                            (uint) b.Length));
                    }
                    lastoffsetidx = (uint)ar.Table.Offsets.Count;
                    
                    flags = cr2w.Buffers.Count > 0 ? cr2w.Buffers.Count - 1 : 0;
                }
                else
                {
                    // kraken the file and write
                    fileStream.Seek(0, SeekOrigin.Begin);
                    var cr2winbuffer = Catel.IO.StreamExtensions.ToByteArray(fileStream);
                    var (zsize, crc) = bw.CompressAndWrite(cr2winbuffer);
                    ar.Table.Offsets.Add(new OffsetEntry((ulong) bw.BaseStream.Position, zsize,
                        (uint) cr2winbuffer.Length));
                }
                
                // save table data
                var sha1 = new System.Security.Cryptography.SHA1Managed();
                var sha1hash = sha1.ComputeHash(Catel.IO.StreamExtensions.ToByteArray(fileBinaryReader.BaseStream)); //TODO: this is only correct for files with no buffer
                var item = new ArchiveItem(hash, DateTime.Now, (uint)flags
                    , firstoffsetidx, lastoffsetidx, 
                    firstimportidx, lastimportidx
                    , sha1hash);
                ar.Table.FileInfo.Add(hash, item);
                

                Interlocked.Increment(ref progress);
                Logger.LogProgress(progress / (float)fileInfos.Count);
            };

            #endregion

            #region write footer

            // padding to page (4096 bytes)
            bw.PadUntilPage();

            // write tables
            var tableoffset = bw.BaseStream.Position;
            ar.Table.Write(bw);
            var tablesize = bw.BaseStream.Position - tableoffset;

            // padding to page (4096 bytes)
            bw.PadUntilPage();
            var filesize = bw.BaseStream.Position;

            // write the header again
            ar.Header.Tableoffset = (ulong)tableoffset;
            ar.Header.Tablesize = (uint)tablesize;
            ar.Header.Filesize = (ulong)filesize;
            bw.BaseStream.Seek(0, SeekOrigin.Begin);
            ar.Header.Write(bw);

            #endregion

            return ar;

            #region Local Functions

            
            
            #endregion
        }
        
        /// <summary>
        /// Kraken-compresses a buffer and writes it to a stream.
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="inbuffer"></param>
        /// <returns></returns>
        public static (uint, uint) CompressAndWrite(this BinaryWriter bw, byte[] inbuffer)
        {
            var size = (uint)inbuffer.Length;
            if (size < 255)
            {
                var crc = Crc32Algorithm.Compute(inbuffer);
                bw.Write(inbuffer);

                return (size, crc);
            }
            else
            {
                IEnumerable<byte> outBuffer = new List<byte>();
                var r = OodleHelper.Compress(
                    inbuffer, 
                    (int)size,
                    ref outBuffer);

                var b = outBuffer.ToArray();
                
                var crc = Crc32Algorithm.Compute(b);
                bw.Write(b);

                return ((uint)r, crc);
            }
        }
        
    }
}