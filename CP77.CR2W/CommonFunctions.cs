using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Catel.IoC;
using Catel.Linq;
using CP77.Common.Services;
using CP77.Common.Tools;
using CP77.Common.Tools.FNV1A;
using CP77.CR2W.Archive;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WolvenKit.Common.Tools.DDS;
using CP77.CR2W.Types;
using CP77Tools.Model;
using WolvenKit.Common;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W
{
    public static class CommonFunctions
    {
        /// <summary>
        /// Imports a raw File to a RedEngine file (e.g. .dds to .xbm, .fbx to .mesh)
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static CR2WFile Import(FileInfo rawFile, FileInfo existingCr2w = null)
        {
            #region checks
            
            if (rawFile == null) return null;
            if (!rawFile.Exists) return null;
            if (rawFile.Directory != null && !rawFile.Directory.Exists) return null;
            if (!Enum.GetNames(typeof(ERawFileFormat)).Contains(rawFile.Extension[1..])) return null;
            if (existingCr2w != null)
            {
                if (!existingCr2w.Exists) return null;
                if (!Enum.GetNames(typeof(ECookedFileFormat)).Contains(rawFile.Extension[1..])) return null;
            }
            
            #endregion
            
            //switch ERawFileFormat
            if (!Enum.TryParse(rawFile.Extension, out ERawFileFormat rawFileFormat))
                return null;
            switch (rawFileFormat)
            {
                case ERawFileFormat.tga:
                case ERawFileFormat.dds:
                    return ImportXbm(rawFile, existingCr2w);
                case ERawFileFormat.fbx:
                    throw new NotImplementedException();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static CR2WFile ImportXbm(FileInfo rawFile, FileInfo existingCr2w = null)
        {
            var rawExt = rawFile.Extension;
            // TODO: do this in a working directory?
            var ddsPath = Path.ChangeExtension(rawFile.FullName, "dds");
            // convert to dds if not already
            if (rawExt != "dds")
            {
                try
                {
                    TexconvWrapper.Convert(rawFile.Directory.FullName, $"{ddsPath}", EUncookExtension.dds);
                }
                catch (Exception e)
                {
                    //TODO: proper exception handling
                    return null;
                }
                
                if (!File.Exists(ddsPath)) return null;
            }
                
            // read dds metadata
            var ddsMetadata = DDSUtils.ReadHeader(ddsPath);

            if (existingCr2w != null)
            {
                // update cr2w file with dds metadata
                
            }
            else
            {
                // create new cr2w file
                
                // populate with dds metadata
            }
            
            // kraken ddsfile
            // remove dds header
            
            // compress file
            
            // append to cr2wfile
            
            // update cr2w headers

            throw new NotImplementedException();
        }
        
        
        
        /// <summary>
        /// Creates and archive from a folder and packs all files inside into it
        /// </summary>
        /// <param name="infolder"></param>
        /// <param name="outpath"></param>
        /// <returns></returns>
        public static Archive.Archive WriteFromFolder(DirectoryInfo infolder, DirectoryInfo outpath)
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

                // read the cr2w and get imports
                using var cr2wfs = new FileStream(fileInfo.FullName, FileMode.Open);
                using var cr2wbr = new BinaryReader(cr2wfs);

                // peak if cr2w
                var magic = cr2wbr.ReadUInt32();
                var isCr2wFile = magic == CR2WFile.MAGIC;
                cr2wbr.BaseStream.Seek(0, SeekOrigin.Begin);

                var cr2w = new CR2WFile();
                if (isCr2wFile)
                {
                    try
                    {
                        cr2w.ReadImportsAndBuffers(cr2wbr);
                    }
                    catch (Exception e)
                    {
                        logger.LogString($"Failed to read cr2w file {fileInfo.FullName}", Logtype.Error);
                        continue;
                    }
                }
                else
                {

                }
                
                //register imports
                uint firstimportidx = (uint)ar.Table.Dependencies.Count;

                foreach (var cr2WImportWrapper in cr2w.Imports)
                {
                    if (!ar.Table.Dependencies.Select(_ => _.HashStr).Contains(cr2WImportWrapper.DepotPathStr))
                        ar.Table.Dependencies.Add(
                            new HashEntry(FNV1A64HashAlgorithm.HashString(cr2WImportWrapper.DepotPathStr)));
                }
                uint lastimportidx = (uint)ar.Table.Dependencies.Count;

                // kraken the file and write
                var cr2wfilesize = (int)cr2w.Header.fileSize;
                cr2wbr.BaseStream.Seek(0, SeekOrigin.Begin);
                var cr2winbuffer = cr2wbr.ReadBytes(cr2wfilesize);
                CompressAndWrite(cr2winbuffer);

                // TODO: each cr2w needs to have the buffer already kraken'd
                // foreach buffer write
                var bufferOffsets = cr2w.Buffers.Select(_ => _.Buffer);
                uint firstoffsetidx = (uint)ar.Table.Offsets.Count - 1;
                foreach (var buffer in bufferOffsets)
                {
                    var bsize = buffer.memSize;
                    var bzsize = buffer.diskSize;
                    cr2wbr.BaseStream.Seek(buffer.offset, SeekOrigin.Begin);
                    var b = cr2wbr.ReadBytes((int)bzsize);
                    ar.Table.Offsets.Add(new OffsetEntry(
                        (ulong)bw.BaseStream.Position,
                        bzsize,
                        bsize));
                    bw.Write(b);
                }
                uint lastoffsetidx = (uint)ar.Table.Offsets.Count;

                // save table data
                var sha1 = new System.Security.Cryptography.SHA1Managed();
                var sha1hash = sha1.ComputeHash(Catel.IO.StreamExtensions.ToByteArray(cr2wbr.BaseStream)); //TODO: this is only correct for files with no buffer
                var flags = cr2w.Buffers.Count > 0 ? (uint)cr2w.Buffers.Count - 1 : 0;
                var item = new ArchiveItem(hash, DateTime.Now, flags
                    , firstoffsetidx, lastoffsetidx, firstimportidx, lastimportidx
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

            int CompressAndWrite(byte[] inbuffer)
            {
                var size = (uint)inbuffer.Length;
                if (size < 255)
                {
                    ar.Table.Offsets.Add(new OffsetEntry(
                        (ulong)bw.BaseStream.Position,
                        size,
                        size));
                    bw.Write(inbuffer);
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

                    ar.Table.Offsets.Add(new OffsetEntry(
                        (ulong)bw.BaseStream.Position,
                        (uint)r + 8,
                        size));
                    bw.Write(writelist.ToArray());
                }

                return 1;
            }
            
            #endregion
        }
        
        /// <summary>
        /// Gets the DXGI format for CP77 dds buffers from a given ETextureCompression and ETextureRawFormat
        /// </summary>
        /// <param name="compression"></param>
        /// <param name="rawFormat"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static EFormat GetDXGIFormat(ETextureCompression compression, ETextureRawFormat rawFormat)
        {
            switch (compression)
            {
                case ETextureCompression.TCM_QualityR:
                    return EFormat.BC4_UNORM;
                case ETextureCompression.TCM_QualityRG:
                case ETextureCompression.TCM_Normalmap:
                    return EFormat.BC5_UNORM;
                case ETextureCompression.TCM_QualityColor:
                    return EFormat.BC7_UNORM;
                case ETextureCompression.TCM_DXTNoAlpha:
                case ETextureCompression.TCM_Normals_DEPRECATED:
                    return EFormat.BC1_UNORM;
                case ETextureCompression.TCM_DXTAlphaLinear:
                case ETextureCompression.TCM_DXTAlpha:
                    return EFormat.BC3_UNORM;
                case ETextureCompression.TCM_None:
                {
                    switch (rawFormat)
                    {
                        case ETextureRawFormat.TRF_Invalid:
                            return EFormat.R8G8B8A8_UNORM;
                        case ETextureRawFormat.TRF_Grayscale_Font:
                            throw new NotImplementedException();
                        case ETextureRawFormat.TRF_R32UI:
                            //return EFormat.R32_UINT;
                            throw new NotImplementedException();
                        case ETextureRawFormat.TRF_DeepColor:
                            return EFormat.R10G10B10A2_UNORM;
                        case ETextureRawFormat.TRF_TrueColor:
                            return EFormat.R8G8B8A8_UNORM;

                        case ETextureRawFormat.TRF_HDRFloat:
                            return EFormat.R32G32B32A32_FLOAT;
                        case ETextureRawFormat.TRF_HDRHalf:
                            return EFormat.R16G16B16A16_FLOAT;
                        case ETextureRawFormat.TRF_HDRFloatGrayscale:
                            return EFormat.R16_FLOAT;
                        case ETextureRawFormat.TRF_R8G8:
                            return EFormat.R8G8_UNORM;


                        case ETextureRawFormat.TRF_Grayscale:
                            return EFormat.R8_UINT;
                        case ETextureRawFormat.TRF_AlphaGrayscale:
                            return EFormat.A8_UNORM;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(rawFormat), rawFormat, null);
                    }
                }

                case ETextureCompression.TCM_RGBE:
                case ETextureCompression.TCM_Normals:
                case ETextureCompression.TCM_NormalsHigh_DEPRECATED:
                case ETextureCompression.TCM_NormalsHigh:
                case ETextureCompression.TCM_NormalsGloss_DEPRECATED:
                case ETextureCompression.TCM_NormalsGloss:
                case ETextureCompression.TCM_TileMap:
                case ETextureCompression.TCM_HalfHDR_Unsigned:
                case ETextureCompression.TCM_HalfHDR:
                case ETextureCompression.TCM_HalfHDR_Signed:
                case ETextureCompression.TCM_Max:
                    throw new NotImplementedException();
                default:
                    throw new ArgumentOutOfRangeException(nameof(compression), compression, null);
            }


        }
    }
}
