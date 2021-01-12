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
            
            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            
            //TODO: Prepare the cr2w File in a previous step
            //TODO: get textures, fbx and other buffer data.
            
            
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

            Thread.Sleep(1000);
            int progress = 0;
            logger.LogProgress(0);

            var allfiles = infolder.GetFiles("*", SearchOption.AllDirectories);
            var parentfiles = allfiles.Where(_ => _.Extension != ".buffer");
            var fileInfos = parentfiles
                .OrderBy(_ => FNV1A64HashAlgorithm.HashString(GetRelpath(_)))
                .ToList();

            string GetRelpath(FileInfo infi) => infi.FullName[(infolder.FullName.Length + 1)..];

            foreach (var fileInfo in fileInfos)
            {
                var relpath = GetRelpath(fileInfo);
                var hash = FNV1A64HashAlgorithm.HashString(relpath);
                if (fileInfo.Extension == ".bin")
                    hash = ulong.Parse(Path.GetFileNameWithoutExtension(relpath));

                using var fileStream = new FileStream(fileInfo.FullName, FileMode.Open);
                using var fileBinaryReader = new BinaryReader(fileStream);

                // peak if cr2w
                if (fileStream.Length < 4) 
                    continue;
                var magic = fileBinaryReader.ReadUInt32();
                var isCr2wFile = magic == CR2WFile.MAGIC;
                
                // fileinfo data
                uint firstimportidx = (uint)ar.Table.Dependencies.Count;
                uint lastimportidx = (uint)ar.Table.Dependencies.Count;
                uint firstoffsetidx = (uint)ar.Table.Offsets.Count - 1; //TODO?
                uint lastoffsetidx = (uint)ar.Table.Offsets.Count;
                int flags = 0;
                
                if (isCr2wFile)
                {
                    var cr2w = new CR2WFile();
                    
                    try
                    {
                        //TODO: verify cr2w integrity
                        
                        
                        fileBinaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                        cr2w.ReadImportsAndBuffers(fileBinaryReader);
                    }
                    catch (Exception e)
                    {
                        logger.LogString($"Failed to read cr2w file {fileInfo.FullName}", Logtype.Error);
                        continue;
                    }
                    
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
                    var (zsize, ctc) = bw.CompressAndWrite(cr2winbuffer);
                    ar.Table.Offsets.Add(new OffsetEntry((ulong) bw.BaseStream.Position, zsize,
                        (uint) cr2winbuffer.Length));
                    
                    // TODO: each cr2w needs to have the buffer already kraken'd
                    // foreach buffer write
                    var bufferOffsets = cr2w.Buffers.Select(_ => _.Buffer);
                    foreach (var buffer in bufferOffsets)
                    {
                        var bsize = buffer.memSize;
                        var bzsize = buffer.diskSize;
                        fileBinaryReader.BaseStream.Seek(buffer.offset, SeekOrigin.Begin);
                        var b = fileBinaryReader.ReadBytes((int)bzsize);
                        ar.Table.Offsets.Add(new OffsetEntry(
                            (ulong)bw.BaseStream.Position,
                            bzsize,
                            bsize));
                        bw.Write(b);
                    }
                    lastoffsetidx = (uint)ar.Table.Offsets.Count;
                    
                    flags = cr2w.Buffers.Count > 0 ? cr2w.Buffers.Count - 1 : 0;
                }
                else
                {
                    // kraken the file and write
                    var cr2winbuffer = File.ReadAllBytes(fileInfo.FullName);
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
                logger.LogProgress(progress / (float)fileInfos.Count);
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
            if (size < 255 || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                var crc = Crc32Algorithm.Compute(inbuffer);
                bw.Write(inbuffer);

                return (size, crc);
            }
            else
            {
                var zsize = OodleHelper.GetCompressedBufferSizeNeeded((int)size);
                var outBuffer = new byte[zsize];

                var r = OodleHelper.Compress(
                    inbuffer, 0,
                    (int)size,
                    outBuffer,
                    0,
                    zsize);
                if (r != zsize)
                {
                    //Debugger.Break();
                }

                //resize buffer
                var writelist = new List<byte>()
                {
                    0x4B, 0x41, 0x52, 0x4B  //KRAKEN, TODO: make this variable and dependent on the compression algo
                };
                writelist.AddRange(BitConverter.GetBytes(size));
                writelist.AddRange(outBuffer.Take(r));

                var b = writelist.ToArray();
                var crc = Crc32Algorithm.Compute(b);
                bw.Write(b);

                return ((uint)r + 8, crc);
            }
        }
        
    }
}