using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.Common.Services;
using CP77.Common.Tools.FNV1A;
using CP77.CR2W.Archive;
using CP77.CR2W.Extensions;
using CP77.CR2W.Types;
using CP77.CR2W.Uncooker;
using WolvenKit.Common;
using WolvenKit.Common.Tools.DDS;

namespace CP77.CR2W
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public static partial class ModTools
    {
        /// <summary>
        /// Uncooks a single file by hash. This will both extract and uncook the redengine file
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <param name="uncookext"></param>
        /// <param name="flip"></param>
        /// <returns></returns>
        public static int UncookSingle(this Archive.Archive ar, ulong hash, DirectoryInfo outDir, 
            EUncookExtension uncookext = EUncookExtension.tga, bool flip = false)
        {
            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);
            
            return ar.UncookSingleInner(hash, outDir, uncookext, flip);
        }
        
        private static int UncookSingleInner(this Archive.Archive ar, ulong hash, DirectoryInfo outDir, EUncookExtension uncookext = EUncookExtension.tga, bool flip = false)
        {
            // checks
            if (!ar.Files.ContainsKey(hash))
                return -1;
            var name = ar.Files[hash].FileName;
            var infile = new FileInfo(Path.Combine(outDir.FullName,
                $"{name}"));
            if (infile.Directory == null)
                return -1;

            
            var (file, buffers) = ar.GetFileData(hash, false);

            Unbundle(file, buffers, infile);

            using var ms = new MemoryStream(file);
            using var br = new BinaryReader(ms);
            
            var ext = Path.GetExtension(name)[1..];

            var uncooksuccess = false;
            if (Enum.GetNames(typeof(ECookedFileFormat)).Contains(ext))
            {
                if (!Enum.TryParse(ext, true, out ECookedFileFormat extAsEnum))
                    return -1;

                var cr2w = TryReadCr2WFile(br);
                if (cr2w == null)
                {
                    Logger.LogString($"Failed to read cr2w file {infile.FullName}", Logtype.Error);
                    return -1;
                }

                cr2w.FileName = infile.FullName;

                //TODO: do this better?
                (_, buffers) = ar.GetFileData(hash, true);
                uncooksuccess = Uncook(cr2w, buffers, extAsEnum, uncookext, flip) == 1;
            }
            else // extract buffers
            {
                var cr2w = TryReadCr2WFileHeaders(br);
                if (cr2w == null)
                {
                    Logger.LogString($"Failed to read cr2w file {infile.FullName}", Logtype.Error);
                    return -1;
                }

                for (int i = 0; i < buffers.Count; i++)
                {
                    var buffer = buffers[i];
                    var bufferpath = $"{infile}.{i}.buffer";
                    Directory.CreateDirectory(infile.Directory.FullName);
                    File.WriteAllBytes(bufferpath, buffer);
                }
                uncooksuccess = true;
            }

            return uncooksuccess ? 1 : 0;
        }
        
        /// <summary>
        /// Uncooks all Files to the specified directory.
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="outDir"></param>
        /// <param name="pattern"></param>
        /// <param name="regex"></param>
        /// <param name="uncookext"></param>
        /// <param name="flip"></param>
        /// <returns></returns>
        public static (List<string>, int) UncookAll(this Archive.Archive ar, DirectoryInfo outDir, string pattern = "", string regex = "", EUncookExtension uncookext = EUncookExtension.tga, bool flip = false)
        {
            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();
            
            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);
            
            // check search pattern then regex
            IEnumerable<ArchiveItem> finalmatches = ar.Files.Values;
            if (!string.IsNullOrEmpty(pattern))
                finalmatches = ar.Files.Values.MatchesWildcard(item => item.FileName, pattern);
            if (!string.IsNullOrEmpty(regex))
            {
                var searchTerm = new System.Text.RegularExpressions.Regex($@"{regex}");
                var queryMatchingFiles =
                    from file in finalmatches
                    let matches = searchTerm.Matches(file.FileName)
                    where matches.Count > 0
                    select file;

                finalmatches = queryMatchingFiles;
            }

            var finalMatchesList = finalmatches.Where(_ => ar.CanUncook(_.NameHash64)).ToList();
            logger.LogString($"Found {finalMatchesList.Count} bundle entries to uncook.", Logtype.Important);

            Thread.Sleep(1000);
            int progress = 0;
            logger.LogProgress(0);
            Parallel.ForEach(finalMatchesList, info =>
            {
                var uncooked = ar.UncookSingleInner(info.NameHash64, outDir, uncookext, flip);

                if (uncooked != 0)
                    extractedList.Add(info.FileName);
                else
                    failedList.Add(info.FileName);
                Interlocked.Increment(ref progress);
                logger.LogProgress(progress / (float)finalMatchesList.Count);
            });

            foreach (var failed in failedList)
            {
                logger.LogString($"Failed to uncook {failed}.", Logtype.Error);
            }

            return (extractedList.ToList(), finalMatchesList.Count);
        }

        
        /// <summary>
        /// 
        /// </summary>
        public static int Uncook(CR2WFile cr2w, List<byte[]> buffers, ECookedFileFormat ext, 
            EUncookExtension uncookext = EUncookExtension.tga, bool flip = false)
        {
            var infile = new FileInfo(cr2w.FileName);
            var uncooksuccess = false;

            // uncook textures, meshes etc
            switch (ext)
            {
                case ECookedFileFormat.xbm:
                {
                    if (buffers.Count > 1)
                        return -1; //TODO: can that happen?
                    if (cr2w.StringDictionary[1] != "CBitmapTexture")
                        return -1;


                    if (!(cr2w.Chunks.FirstOrDefault()?.data is CBitmapTexture xbm) ||
                        !(cr2w.Chunks[1]?.data is rendRenderTextureBlobPC blob))
                        return -1;

                    // create dds header
                    var newpath = Path.ChangeExtension(infile.FullName, "dds");
                    try
                    {
                        #region get xbm data

                        var width = blob.Header.SizeInfo.Width.val;
                        var height = blob.Header.SizeInfo.Height.val;
                        var mips = blob.Header.TextureInfo.MipCount.val;
                        var slicecount = blob.Header.TextureInfo.SliceCount.val;
                        var alignment = blob.Header.TextureInfo.DataAlignment.val;

                        Enums.ETextureRawFormat rawfmt = Enums.ETextureRawFormat.TRF_Invalid;
                        if (xbm.Setup.RawFormat?.WrappedEnum != null)
                            rawfmt = xbm.Setup.RawFormat.WrappedEnum;
                        else
                        {
                        }

                        Enums.ETextureCompression compression = Enums.ETextureCompression.TCM_None;
                        if (xbm.Setup.Compression?.WrappedEnum != null)
                            compression = xbm.Setup.Compression.WrappedEnum;
                        else
                        {
                        }

                        var texformat = CommonFunctions.GetDXGIFormat(compression, rawfmt);

                        #endregion

                        // extract and write buffer 
                        Directory.CreateDirectory(infile.Directory.FullName);
                        using (var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write))
                        {
                            DDSUtils.GenerateAndWriteHeader(ddsStream,
                                new DDSMetadata(width, height, mips, texformat, alignment, false, slicecount,
                                    true));
                            ddsStream.Write(buffers[0]);


                        }

                        if (flip && RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                            TexconvWrapper.VFlip(infile.Directory.FullName, newpath, texformat);
                        // success
                        uncooksuccess = true;
                    }
                    catch
                    {
                        uncooksuccess = false;
                        return -1;
                    }

                    // convert to texture
                    if (uncookext != EUncookExtension.dds && RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        try
                        {
                            var di = new FileInfo(infile.FullName).Directory;
                            TexconvWrapper.Convert(di.FullName, $"{newpath}", uncookext);
                        }
                        catch (Exception e)
                        {
                            // silent
                        }
                    }

                    break;
                }
                case ECookedFileFormat.csv:
                {
                    if (buffers.Count > 0)
                        return -1; //TODO: can that happen?
                    if (cr2w.StringDictionary[1] != "C2dArray")
                        return -1;


                    if (!(cr2w.Chunks.FirstOrDefault() is {data: C2dArray redcsv}))
                        return -1;

                    // write
                    var newpath = $"{infile.FullName}.csv";

                    Directory.CreateDirectory(infile.Directory.FullName);
                    using var nstream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    redcsv.ToCsvStream(nstream);


                    break;
                }
                case ECookedFileFormat.json:
                {

                    break;
                }
                case ECookedFileFormat.mlmask:
                {

                    try
                    {
                        if (!Mlmask.Uncook(cr2w, buffers, infile, uncookext))
                            return -1;
                        uncooksuccess = true;
                    }
                    catch
                    {
                        uncooksuccess = false;
                    }

                    break;
                }
                case ECookedFileFormat.cubemap:
                {


                    if (!(cr2w.Chunks.FirstOrDefault()?.data is CCubeTexture ctex) ||
                        !(cr2w.Chunks[1]?.data is rendRenderTextureBlobPC blob))
                        return -1;

                    try
                    {
                        var sliceCount = blob.Header.TextureInfo.SliceCount.val;
                        var mipCount = blob.Header.TextureInfo.MipCount.val;
                        var alignment = blob.Header.TextureInfo.DataAlignment.val;

                        var height = blob.Header.SizeInfo.Height.val;
                        var width = blob.Header.SizeInfo.Width.val;


                        Enums.ETextureCompression compression = Enums.ETextureCompression.TCM_None;
                        Enums.ETextureRawFormat rawfmt = Enums.ETextureRawFormat.TRF_Invalid;

                        if (ctex.Setup.RawFormat?.WrappedEnum != null)
                            rawfmt = ctex.Setup.RawFormat.WrappedEnum;

                        if (ctex.Setup.Compression?.WrappedEnum != null)
                            compression = ctex.Setup.Compression.WrappedEnum;

                        var texformat = CommonFunctions.GetDXGIFormat(compression, rawfmt);

                        Directory.CreateDirectory(infile.Directory.FullName);

                        var newpath = Path.ChangeExtension(infile.FullName, "dds");

                        using (var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write))
                        {
                            DDSUtils.GenerateAndWriteHeader(ddsStream,
                                new DDSMetadata(width, height, mipCount, texformat, alignment, false, sliceCount,
                                    true));
                            ddsStream.Write(buffers[0]);
                        }

                        uncooksuccess = true;
                    }
                    catch
                    {
                        uncooksuccess = false;
                    }

                    break;
                }
                case ECookedFileFormat.envprobe:
                {


                    if (!(cr2w.Chunks.FirstOrDefault()?.data is CReflectionProbeDataResource probe) ||
                        !(cr2w.Chunks[1]?.data is rendRenderTextureBlobPC blob))
                        return -1;

                    try
                    {
                        var sliceCount = blob.Header.TextureInfo.SliceCount.val;
                        var mipCount = blob.Header.TextureInfo.MipCount.val;
                        var alignment = blob.Header.TextureInfo.DataAlignment.val;

                        var height = blob.Header.SizeInfo.Height.val;
                        var width = blob.Header.SizeInfo.Width.val;

                        EFormat texformat = EFormat.R8G8B8A8_UNORM;

                        Directory.CreateDirectory(infile.Directory.FullName);

                        var newpath = Path.ChangeExtension(infile.FullName, "dds");

                        using (var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write))
                        {
                            DDSUtils.GenerateAndWriteHeader(ddsStream,
                                new DDSMetadata(width, height, mipCount, texformat, alignment, false, sliceCount,
                                    true));
                            ddsStream.Write(buffers[0]);
                        }

                        uncooksuccess = true;
                    }
                    catch
                    {
                        uncooksuccess = false;
                    }

                    break;
                }
                case ECookedFileFormat.texarray:
                {


                    if (!(cr2w.Chunks.FirstOrDefault()?.data is CTextureArray texa) ||
                        !(cr2w.Chunks[1]?.data is rendRenderTextureBlobPC blob))
                        return -1;

                    try
                    {
                        var sliceCount = blob.Header.TextureInfo.SliceCount.val;
                        var mipCount = blob.Header.TextureInfo.MipCount.val;
                        var alignment = blob.Header.TextureInfo.DataAlignment.val;

                        var height = blob.Header.SizeInfo.Height.val;
                        var width = blob.Header.SizeInfo.Width.val;

                        Enums.ETextureRawFormat rawfmt = Enums.ETextureRawFormat.TRF_Invalid;
                        if (texa.Setup.RawFormat?.WrappedEnum != null)
                            rawfmt = texa.Setup.RawFormat.WrappedEnum;

                        Enums.ETextureCompression compression = Enums.ETextureCompression.TCM_None;
                        if (texa.Setup.Compression?.WrappedEnum != null)
                            compression = texa.Setup.Compression.WrappedEnum;

                        var texformat = CommonFunctions.GetDXGIFormat(compression, rawfmt);

                        Directory.CreateDirectory(infile.Directory.FullName);

                        var newpath = Path.ChangeExtension(infile.FullName, "dds");

                        using (var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write))
                        {
                            DDSUtils.GenerateAndWriteHeader(ddsStream,
                                new DDSMetadata(width, height, mipCount, texformat, alignment, false, sliceCount,
                                    true));
                            ddsStream.Write(buffers[0]);
                        }

                        uncooksuccess = true;
                    }
                    catch
                    {
                        uncooksuccess = false;
                    }

                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }


            return uncooksuccess ? 1 : 0;
        }
    }
}